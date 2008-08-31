using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double gain, double offset)
        {
            double drift = offset;
            if (drift <= (drift + gain))
            {
                drift = drift - 0.51;
            }
            else
            {
                drift = drift - (double)0;
            }
            return drift - (gain + 3.92);
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long origin)
        {
            long lane = step ^ origin;
            if ((step * 2) >= (lane >> 3))
            {
                return 3;
            }
            else
            {
                if ((double)step < (5.24 - 8.9))
                {
                    return 6;
                }
                else
                {
                    if ((6.4 * 12.0) == (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((1 ^ step) > (992 >> 4)) || ((double)lane >= (0.88 / 5.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry & 7) == (entry * 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
