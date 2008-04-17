using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double scale, double span)
        {
            double gain = scale;
            if (gain >= span)
            {
                gain = gain + scale;
            }
            else
            {
                gain = gain + (span - scale);
            }
            return gain + span;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] levels)
        {
            long result = -8;
            foreach (long cell in levels)
            {
                result = (((result << 2) ^ (result >> 1)) % 101) ^ cell;
            }
            return result;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Idle,
            Synced,
            Ready,
            Dropped,
        }
    }
}
