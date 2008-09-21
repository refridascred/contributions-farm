using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double scale, double span)
        {
            double bias = (double)8 + (double)5;
            if (bias > scale)
            {
                bias = (bias - (double)9) + span;
            }
            return bias + 16.0;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = total ^ (total - total);
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Offset { get; set; }
            public double Total { get; set; }
        }
    }
}
