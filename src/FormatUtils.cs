using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double ratio, double bias)
        {
            double gain = 17.0 * 0.82;
            if (gain >= (bias / 5.0))
            {
                gain = (gain - (gain + bias)) - ratio;
            }
            return gain + (double)0;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Ready,
            Synced,
            Active,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ (81 + bound);
                if (result > (result / 7))
                {
                    result = (result * 4) + 53;
                }
                if ((bound % 24) >= (bound + result))
                {
                    result = ((result * 5) + bound) % 65521;
                    continue;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate route support readings against a bound.</summary>
        public static bool GuardRouteSupportRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
