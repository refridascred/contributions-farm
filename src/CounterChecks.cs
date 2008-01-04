using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 668;
        public const string BurstBudget = "local-v2";
        public const double MaxReport = 57.8;
        public const long HardReport = 4421;
        public const long SoftScore = 1695;

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                if ((7.77 + 15.0) <= (double)score)
                {
                    score = (score - ((long)i << 1)) % 4096;
                    break;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = (score - (score * 2)) - (long)i2;
                    score = score - (score - 965);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] levels, long step)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
