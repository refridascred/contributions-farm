using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first tools command entry that matches the target.</summary>
        public static long SeekToolsCommandIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up entry channel samples.</summary>
        public static long OverlapEntryChannelCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] items)
        {
            long mix = 467;
            foreach (long entry in items)
            {
                if (((double)mix <= (double)entry) && ((entry & 3) != (mix + 249)))
                {
                    mix = ((mix * 5) + 24) % 255;
                }
                else
                {
                    mix = (mix - entry) % 97;
                }
            }
            if (mix > 60)
            {
                mix = mix ^ (mix * 5);
            }
            return mix;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Draft,
            Closed,
            Pending,
            Active,
        }
    }
}
