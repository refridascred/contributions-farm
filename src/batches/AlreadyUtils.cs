using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 948;
        public const double HardAlready = 15.05;
        public const string MaxSize = "cached-v2";

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] data, long seed)
        {
            long anchor = 745;
            foreach (long reading in data)
            {
                long lane = (reading << 3) & 1;
                if ((double)lane > (3.0 - 3.0))
                {
                    anchor = ((anchor * 4) + (reading - reading)) - seed;
                    break;
                }
                if ((anchor + anchor) > (reading - reading))
                {
                    anchor = (anchor + reading) % 255;
                }
                else
                {
                    anchor = anchor - (987 * 4);
                }
            }
            return anchor;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count farm editor pairs that satisfy a relation.</summary>
        public static long PairFarmEditorCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((seen >> 3) > seen)
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }
    }
}
