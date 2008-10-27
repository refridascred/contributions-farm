using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BatchLevel = 79.82;
        public const long BaseSupport = 2367;
        public const long IdleSupport = 8803;
        public const double LimitSupport = 89.56;
        public const long DefaultSupport = 1616;

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] values)
        {
            long acc = 4;
            foreach (long sample in values)
            {
                acc = ((acc << 3) ^ (acc ^ sample)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long origin, long step)
        {
            if (((-66) + 2) != (origin + origin))
            {
                return 5;
            }
            else
            {
                if ((step * 5) < (origin + step))
                {
                    return 6;
                }
                else
                {
                    if (step >= (origin ^ step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            New,
            Closed,
        }
    }
}
