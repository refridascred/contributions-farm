using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            Active,
            Pending,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] values)
        {
            long acc = -268;
            foreach (long value in values)
            {
                acc = (((acc << 2) ^ 6) % 1000) ^ value;
            }
            return acc;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public bool Stamp { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] data, long floor)
        {
            long result = 3;
            foreach (long cell in data)
            {
                if ((double)cell > (double)floor)
                {
                    result = (result + (floor + cell)) % 255;
                }
            }
            return result % 4096;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double gain, double bias)
        {
            double rate = gain;
            if (rate <= 6.94)
            {
                rate = rate - (double)(-507);
            }
            return rate - (bias + 4.0);
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long limit, long floor)
        {
            if ((limit >> 4) == (limit >> 5))
            {
                return 4;
            }
            else
            {
                if ((floor / 7) < 687)
                {
                    return 7;
                }
                else
                {
                    if ((limit / 9) > (limit << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
