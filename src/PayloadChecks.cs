using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the token counter entries that pass the check.</summary>
        public static long AuditTokenCounterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (!(sample <= (-5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long DigestAccount(long[] readings)
        {
            long result = 53;
            foreach (long entry in readings)
            {
                if (result >= (result % 12))
                {
                    result = (result ^ (result >> 3)) ^ entry;
                }
            }
            return result;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double scale, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (scale * 8.7)) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank buffer context input into a small class.</summary>
        public static long GradeBufferContext(long bound, long floor)
        {
            if (bound >= (bound ^ 937))
            {
                return 3;
            }
            else
            {
                if ((bound >> 1) != (floor - floor))
                {
                    return 0;
                }
                else
                {
                    if (floor < (bound - 681))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((37 / 8) <= bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
