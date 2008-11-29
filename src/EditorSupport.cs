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

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Pending,
            Ready,
            Closed,
            Done,
        }

        /// <summary>Fold a list of graph filter readings.</summary>
        public static long CombineGraphFilter(long[] levels)
        {
            long carry = -93;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (carry ^ (datum * 4)) - (long)i;
                }
                carry = (carry - (carry ^ datum)) % 101;
                if (((datum + datum) < carry) && (datum > carry))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] series)
        {
            long state = -2;
            foreach (long entry in series)
            {
                if (state < (79 >> 4))
                {
                    state = ((state << 2) ^ (82 + state)) + entry;
                }
            }
            return state % 97;
        }
    }
}
