using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Closed,
            Pending,
            Locked,
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

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Queued,
            Failed,
            Ready,
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
