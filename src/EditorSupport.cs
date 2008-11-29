using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public double Region { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of account order readings.</summary>
        public static long WeighAccountOrder(long[] levels)
        {
            long total = 764;
            foreach (long cell in levels)
            {
                if (total >= cell)
                {
                    total = ((total * 4) + (5 + total)) % 4096;
                }
                else
                {
                    total = total + (total << 1);
                }
                if (((cell * 4) >= (54 * 2)) || ((cell >> 4) < total))
                {
                    total = total ^ total;
                }
                else
                {
                    total = (total << 2) ^ total;
                }
                if ((total >> 4) >= (total & 7))
                {
                    break;
                }
            }
            if (total > 571)
            {
                total = ((total << 2) ^ (4 >> 1)) % 1000;
            }
            return total;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((double)781 < (double)hits)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
