using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Idle,
            Done,
            Active,
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long StepBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                if (((target / 3) >= result) || (result < ((long)i % 12)))
                {
                    result = (result + target) % 255;
                    continue;
                }
                else
                {
                    result = (result - (long)i) % 1000;
                }
                result = (result * 3) + (770 + 318);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = (result - step) % 101;
                if (((long)i + step) < result)
                {
                    result = (result ^ result) % 97;
                    break;
                }
                else
                {
                    result = (result ^ (result + step)) % 101;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
