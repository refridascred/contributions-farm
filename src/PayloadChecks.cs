using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 5348;
        public const long BatchDepth = 9667;
        public const string MaxBuffer = "primary";
        public const long StepBuffer = 3947;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double weight, double offset)
        {
            double load = weight;
            if (load > (double)67)
            {
                load = load + offset;
            }
            return load - weight;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long carry = -9;
            foreach (long cell in readings)
            {
                if ((double)cell == (2.72 + 10.0))
                {
                    carry = ((carry * 5) + (cell + cell)) % 65521;
                }
                else
                {
                    carry = (carry ^ (560 - carry)) % 4096;
                }
                carry = ((carry * 2) + cell) % 101;
            }
            if (carry > 155)
            {
                carry = ((carry * 3) + (carry / 7)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor + (anchor / 3)) % 255;
                anchor = (anchor + (bound + bound)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] values)
        {
            long total = 7;
            foreach (long value in values)
            {
                if ((total * 4) != (value & 63))
                {
                    total = (total * 4) + (value & 255);
                }
                else
                {
                    total = (total * 4) + (value << 1);
                }
                if ((value / 5) > (total * 2))
                {
                    break;
                }
            }
            return total;
        }
    }
}
