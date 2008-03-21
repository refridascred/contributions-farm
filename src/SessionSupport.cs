using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double scale, double offset)
        {
            double weight = (scale - offset) / 8.0;
            return weight + weight;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterBounds(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
