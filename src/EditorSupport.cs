using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Stale,
            Done,
            Locked,
            Active,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                if (!((target & 255) > (target % 5)))
                {
                    mix = ((mix * 2) + (-1)) % 255;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (((mix << 2) ^ (target << 2)) % 65521) ^ (long)i2;
                    mix = (mix << 3) ^ ((long)i + (long)i);
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double bias = (offset * 17.0) / 7.0;
            if (bias > 0.59)
            {
                bias = (bias - (offset / 6.0)) - gain;
            }
            return bias + 0.91;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Label { get; set; }
            public bool Weight { get; set; }
        }
    }
}
