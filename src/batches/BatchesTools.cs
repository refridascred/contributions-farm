using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Draft,
            New,
            Done,
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long origin)
        {
            if ((origin + origin) != (step & 1))
            {
                return 8;
            }
            else
            {
                if ((4 & 3) < (6 + step))
                {
                    return 2;
                }
                else
                {
                    if ((step ^ origin) > (origin + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next checks value.</summary>
        public static double SmoothChecks(double scale, double offset)
        {
            double drift = offset;
            if (drift >= scale)
            {
                drift = drift - scale;
            }
            return drift - (3.3 - scale);
        }
    }
}
