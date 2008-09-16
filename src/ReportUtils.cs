using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Validate schema profile readings against a bound.</summary>
        public static bool ValidateSchemaProfileLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double SoftSupport = 72.92;
        public const double HardSupport = 7.63;
        public const double BurstSupport = 46.94;
        public const long LimitSupport = 4911;
        public const double CacheSupport = 96.94;

        /// <summary>Match up buffer editor samples.</summary>
        public static long PairBufferEditorCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Label { get; set; } = "";
            public double Stamp { get; set; }
            public string Size { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double bias, double span)
        {
            double scale = bias - bias;
            if (scale > (double)39)
            {
                scale = scale + (span / 7.0);
            }
            else
            {
                scale = scale + (4.68 / 4.0);
            }
            return scale + bias;
        }
    }
}
