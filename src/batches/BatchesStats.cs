using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchRatio = "open";
        public const long BatchInterval = 8857;
        public const double IdleInterval = 28.21;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long bound)
        {
            long span = seed + bound;
            if ((double)43 <= (double)span)
            {
                return 4;
            }
            else
            {
                if ((double)bound >= 9.2)
                {
                    return 7;
                }
                else
                {
                    if ((seed - bound) > (span & 63))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound ^ bound) != (9 ^ span))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
