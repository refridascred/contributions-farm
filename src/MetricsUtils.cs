using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long CombineToken(long[] values, long seed)
        {
            long state = 7;
            foreach (long item in values)
            {
                state = ((state << 2) ^ (item & 63)) - seed;
                if ((item + item) >= (8 << 1))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRecord = 84.03;
        public const long HardDepth = 2724;
        public const long IdleRatio = 1420;

        /// <summary>Fold a list of editor token readings.</summary>
        public static long ScoreEditorToken(long[] data)
        {
            long mix = 492;
            foreach (long item in data)
            {
                if ((item ^ mix) > 1)
                {
                    mix = (mix * 5) + (item + mix);
                }
                if ((item - mix) >= mix)
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = (mix - mix) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((origin << 2) <= ((long)readings.Length >> 4))
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((bound + (long)levels.Length) > entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
