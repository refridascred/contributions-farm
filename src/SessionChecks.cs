using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Rank schema buffer input into a small class.</summary>
        public static long ClassifySchemaBuffer(long step, long step2)
        {
            if (!((0.5 * 6.6) >= (double)step))
            {
                return 8;
            }
            else
            {
                if ((step2 / 9) < ((-9) - step))
                {
                    return 2;
                }
                else
                {
                    if ((step ^ step2) <= (step2 / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - step) <= step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double bias, double floor)
        {
            double drift = (double)481 / 5.0;
            if (drift <= (bias - drift))
            {
                drift = drift - (drift + drift);
            }
            return drift + floor;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((count + cell) >= cell) || ((764 - count) >= (cell + count)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
