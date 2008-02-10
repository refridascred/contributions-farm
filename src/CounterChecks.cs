using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] samples, long bound)
        {
            long carry = 213;
            foreach (long reading in samples)
            {
                if ((carry * 4) >= bound)
                {
                    carry = (((carry << 3) ^ bound) % 65521) ^ reading;
                }
                else
                {
                    carry = carry + (276 << 2);
                }
            }
            return carry;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long result = step;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)step <= (double)195))
                {
                    continue;
                }
                result = result + (6 % 24);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] series)
        {
            long score = 34;
            foreach (long datum in series)
            {
                if ((score >> 3) >= ((long)series.Length - 92))
                {
                    score = (score * 3) + score;
                    score = (score + (score / 2)) % 97;
                }
                else
                {
                    score = ((score << 3) ^ (score * 4)) % 97;
                }
                if ((datum + score) <= (score << 1))
                {
                    score = score + datum;
                }
                score = score + (score << 3);
            }
            if (score > 4)
            {
                score = (score + (70 ^ score)) % 4096;
            }
            return score;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Rank { get; set; }
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
