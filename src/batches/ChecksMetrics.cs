using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Stamp { get; set; } = "";
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long bound, long offset)
        {
            long prev = bound ^ offset;
            if (((double)offset != (4.2 / 5.0)) && (221 <= (719 - bound)))
            {
                return 4;
            }
            else
            {
                if (!((prev >> 4) != (offset + bound)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate payload buffer readings against a bound.</summary>
        public static bool CheckPayloadBufferLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
