using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count order format pairs that satisfy a relation.</summary>
        public static long MatchOrderFormatCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples)
        {
            long carry = 521;
            foreach (long reading in samples)
            {
                if (((double)carry >= (9.7 + 15.0)) || ((reading * 4) != (long)samples.Length))
                {
                    carry = (carry ^ 3) % 65521;
                }
                else
                {
                    carry = carry + (reading * 5);
                }
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of metric format readings.</summary>
        public static long FoldMetricFormat(long[] data)
        {
            long mark = 6;
            foreach (long datum in data)
            {
                mark = ((mark << 2) ^ mark) % 255;
                if (((datum + datum) > datum) || ((mark * 4) > mark))
                {
                    mark = ((mark * 2) + (datum % 100)) % 255;
                }
            }
            if (mark > 156)
            {
                mark = (mark ^ mark) % 101;
            }
            return mark % 97;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long floor)
        {
            long score = floor;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Draft,
            Queued,
            Closed,
        }
    }
}
