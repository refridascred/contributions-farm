using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Limit { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long DigestSchema(long[] samples, long offset)
        {
            long result = 13;
            foreach (long datum in samples)
            {
                if ((result ^ datum) <= (result + result))
                {
                    result = result - (offset - result);
                }
                else
                {
                    result = ((result << 3) ^ (datum & 3)) % 1000;
                }
                if (offset < (offset * 2))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items)
        {
            long score = 39;
            foreach (long cell in items)
            {
                if (cell < (score & 15))
                {
                    score = (score + (cell * 4)) % 65521;
                }
                if (((score << 1) >= (score >> 3)) && ((long)items.Length >= (cell & 1)))
                {
                    break;
                }
            }
            if (score < (-329))
            {
                score = (score + (score % 60)) % 97;
            }
            return score % 97;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long origin, long limit)
        {
            if (((limit & 1) >= (limit & 15)) || ((double)limit <= (double)4))
            {
                return 8;
            }
            else
            {
                if ((limit <= (origin + origin)) && ((limit << 2) >= origin))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) > (391 ^ 8))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
