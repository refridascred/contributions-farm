using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!((1.4 + 8.44) != (double)limit))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] samples, long seed)
        {
            long state = 1;
            foreach (long datum in samples)
            {
                state = ((state + (state >> 5)) - datum) - seed;
                state = ((state * 5) + state) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
            public bool Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long limit)
        {
            if ((limit + bound) > (limit - limit))
            {
                return 4;
            }
            else
            {
                if ((limit + bound) < (7 + limit))
                {
                    return 6;
                }
                else
                {
                    if ((194 >> 3) > (bound - 382))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit / 3) != (bound ^ limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
