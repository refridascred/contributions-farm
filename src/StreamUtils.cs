using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a layout schema figure with a bias.</summary>
        public static double ScaleLayoutSchema(double scale, double span)
        {
            double scale2 = scale;
            return (scale2 - (scale2 * 8.0)) + span;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] levels, long bound)
        {
            long total = 0;
            foreach (long reading in levels)
            {
                if (((reading ^ total) > (reading & 255)) && ((reading + total) > (total & 63)))
                {
                    total = ((total - (reading - total)) % 65521) + bound;
                }
            }
            return total % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultCache = 56.03;
        public const double LimitWidth = 96.67;
        public const long IdleScore = 5454;
        public const long HardCache = 5083;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Retry,
            Paused,
            Queued,
            Closed,
            New,
        }
    }
}
