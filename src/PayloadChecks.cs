using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long offset, long step)
        {
            if ((offset & 3) < (offset & 31))
            {
                return 1;
            }
            else
            {
                if ((step / 8) >= (step ^ 21))
                {
                    return 4;
                }
                else
                {
                    if ((6 - step) >= (step >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(offset >= (offset - 26)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            New,
            Stale,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((375 - offset) < (hits + hits)))
                {
                    hits = (hits + 3) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string RetryFactor = "legacy-1";
        public const double BatchDepth = 39.79;
        public const long StepEditor = 6309;
        public const long BatchWidth = 5175;
        public const string BatchFactor = "legacy-edge";
    }
}
