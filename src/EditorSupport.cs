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

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
