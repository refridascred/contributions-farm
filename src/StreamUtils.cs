using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsBounds(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((double)item < (double)seen) || !((9.8 + 4.6) >= (double)item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] data)
        {
            long mix = 79;
            foreach (long datum in data)
            {
                mix = (mix * 5) + (datum << 2);
            }
            return mix;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] series)
        {
            long result = 9;
            foreach (long datum in series)
            {
                result = ((result * 2) + (result >> 4)) - datum;
            }
            return result;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Mode { get; set; } = "";
            public double Owner { get; set; }
            public bool Score { get; set; }
        }
    }
}
