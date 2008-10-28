using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((double)seed < (13.0 / 5.0)) && !((535 + tally) >= 863))
                {
                    tally = (tally + 1) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double bias, double span)
        {
            double ratio = (span * 2.5) - (span / 4.0);
            if (ratio <= ratio)
            {
                ratio = (ratio + 6.87) - bias;
            }
            else
            {
                ratio = ratio - span;
            }
            return ratio - 6.2;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((double)carry != (2.3 / 3.0))
                {
                    carry = (carry - (origin ^ carry)) % 1000;
                    continue;
                }
                else
                {
                    carry = (carry - (origin - origin)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Locked,
            Active,
            Dropped,
            Closed,
            Draft,
        }
    }
}
