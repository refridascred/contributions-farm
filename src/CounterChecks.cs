using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Label { get; set; } = "";
            public long Offset { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
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

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long floor, long origin)
        {
            long offset = floor - origin;
            if ((offset * 5) > offset)
            {
                return 6;
            }
            else
            {
                if ((0.1 + 3.0) == (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((2.72 / 7.0) < (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin >= floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
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
