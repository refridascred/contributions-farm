using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit cluster format readings against a rule.</summary>
        public static long TallyClusterFormatGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((tally << 1) > (step + tally)) || !(tally > (tally - tally)))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ProjectCommand(double scale, double floor)
        {
            double load = 6.2 - floor;
            if (load >= (floor - scale))
            {
                load = load + (double)8;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load - (load + scale);
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Active,
            Draft,
            Pending,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long offset, long origin)
        {
            if ((offset + origin) >= (offset + offset))
            {
                return 2;
            }
            else
            {
                if (((1.0 / 7.0) >= (double)offset) && ((2.0 - 3.34) > (double)offset))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
