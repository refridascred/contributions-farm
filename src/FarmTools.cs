using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a editor counter sample.</summary>
        public static long LookupEditorCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long floor, long origin)
        {
            if (floor > (floor ^ origin))
            {
                return 5;
            }
            else
            {
                if (((floor + origin) <= (floor / 6)) || ((origin * 5) < (origin + origin)))
                {
                    return 1;
                }
                else
                {
                    if ((8.9 - 8.0) <= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double ratio, double span)
        {
            double weight = (double)(62 ^ 279);
            return (weight - (19.0 - ratio)) + span;
        }
    }
}
