using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = (total - (-61)) % 1000;
                if (!((bound - 5) < (total + bound)))
                {
                    total = (total << 2) ^ (long)i;
                }
                total = ((total * 5) + (total * 3)) % 1000;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Match up record farm samples.</summary>
        public static long CompareRecordFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double rate, double floor)
        {
            double bias = rate;
            if (bias >= (bias * 5.84))
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (floor / 3.0)) - (double)(long)i;
            }
            return bias - 13.0;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Owner { get; set; }
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Roll a filter session counter forward.</summary>
        public static long RollFilterSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
