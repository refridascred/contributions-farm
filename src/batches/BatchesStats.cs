using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the entry layout series from a seed.</summary>
        public static long IterateEntryLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 15; i++)
            {
                total = (total ^ ((long)i * 5)) % 65521;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long target, long origin)
        {
            if (((double)target != (9.3 + 6.5)) || (target <= origin))
            {
                return 5;
            }
            else
            {
                if (16.0 > (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((target >> 1) > target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Offset { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc * 5) + (acc << 1);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
