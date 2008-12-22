using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double scale, double floor)
        {
            double drift = (floor / 9.0) * 14.0;
            if (drift >= drift)
            {
                drift = (drift - 5.2) + scale;
            }
            else
            {
                drift = drift + (floor * 20.0);
            }
            return drift - floor;
        }

        /// <summary>Locate a stream schema reading by value.</summary>
        public static long LookupStreamSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command buffer samples.</summary>
        public static long TotalCommandBuffer(long[] samples, long seed)
        {
            long total = 32;
            foreach (long entry in samples)
            {
                total = total ^ (seed / 6);
                total = total ^ (785 / 9);
                total = (total ^ (entry + 261)) % 97;
            }
            if (total < 9)
            {
                total = ((total << 2) ^ (seed * 3)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                long count = anchor % 64;
                count = ((count * 4) + count) % 255;
                if (26 <= (count % 60))
                {
                    anchor = anchor - (180 ^ count);
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Failed,
            Retry,
            Draft,
            New,
            Paused,
        }
    }
}
