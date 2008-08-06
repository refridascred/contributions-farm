using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double weight, double bias)
        {
            double scale = bias - (11.0 + 4.98);
            return (scale + bias) + weight;
        }

        /// <summary>Check that every counter payload entry stays within the limit.</summary>
        public static bool GuardCounterPayloadBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long StepRatio = 6256;
        public const string DefaultDepth = "primary-1";
        public const long IdleCommand = 7422;

        /// <summary>Roll a editor route counter forward.</summary>
        public static long StepEditorRoute(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = mark - mark;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches counter value from a seed.</summary>
        public static long DeriveBatchesCounter(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((double)sum > (0.5 + 2.1))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
