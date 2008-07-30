using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorLimits(long[] items, long limit)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long seed, long step)
        {
            if (!((seed & 7) < (step + step)))
            {
                return 6;
            }
            else
            {
                if (seed >= (seed + seed))
                {
                    return 0;
                }
                else
                {
                    if (!(step >= (step / 8)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] data)
        {
            long anchor = 726;
            foreach (long reading in data)
            {
                anchor = (anchor << 3) ^ (anchor + anchor);
                anchor = ((anchor * 5) + (anchor % 12)) % 97;
                if (reading <= (5 + (long)data.Length))
                {
                    break;
                }
            }
            if (anchor < (-695))
            {
                anchor = ((anchor * 3) + (anchor + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels)
        {
            long sum = 901;
            foreach (long sample in levels)
            {
                if (((double)sum <= (9.41 * 3.0)) || ((sum + sample) < sum))
                {
                    sum = (sum ^ (sample * 3)) % 97;
                }
                else
                {
                    sum = (sum - (sample + sum)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
