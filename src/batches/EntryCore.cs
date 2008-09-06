using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseLevel = 7758;
        public const long BaseTimeout = 4945;
        public const long StepFilter = 7816;
        public const double BurstRatio = 82.68;
        public const double MinSize = 26.19;

        /// <summary>Validate command filter readings against a bound.</summary>
        public static bool VerifyCommandFilterRange(long[] series, long target)
        {
            bool found = true;
            foreach (long reading in series)
            {
                if (reading < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long seed, long step)
        {
            long lane = seed ^ step;
            if (step > (lane + seed))
            {
                return 6;
            }
            else
            {
                if (((lane & 15) <= (step - (-68))) || ((6.2 / 2.0) <= (double)step))
                {
                    return 7;
                }
                else
                {
                    if (seed >= (step & 127))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step != (double)seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = acc - (acc & 63);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
