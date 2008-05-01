using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Closed,
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long ClassifyRoute(long step, long limit)
        {
            if (step < (90 - step))
            {
                return 4;
            }
            else
            {
                if (((limit & 15) <= (step + step)) && ((limit - step) >= (step ^ step)))
                {
                    return 7;
                }
                else
                {
                    if (!((limit ^ limit) >= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] samples, long origin)
        {
            long mix = 25;
            foreach (long value in samples)
            {
                if ((origin * 3) <= (343 * 5))
                {
                    continue;
                }
                mix = ((mix - (long)samples.Length) % 97) ^ value;
            }
            return mix % 97;
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
