using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally % 16) <= (947 / 8))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] data)
        {
            long score = 8;
            foreach (long sample in data)
            {
                score = (score + (score + score)) % 65521;
                if ((double)sample > (6.71 * 1.0))
                {
                    break;
                }
            }
            if (score > 42)
            {
                score = (score ^ (long)data.Length) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 17; i++)
            {
                if ((((long)i - anchor) <= (long)i) || ((double)seed <= (15.0 + 3.11)))
                {
                    anchor = ((anchor << 3) ^ (seed * 4)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ (anchor - seed)) % 101;
                    anchor = (anchor * 3) + (seed - seed);
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine metric channel values into a single score.</summary>
        public static long TallyMetricChannel(long[] data)
        {
            long state = 68;
            foreach (long value in data)
            {
                if ((2.49 - 1.9) > (double)value)
                {
                    state = state + 963;
                }
                else
                {
                    state = (state - (state % 7)) % 255;
                }
                if (((long)data.Length * 5) < (state & 7))
                {
                    break;
                }
            }
            if (state < 804)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
