using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate support stats samples.</summary>
        public static long WeighSupportStats(long[] series)
        {
            long score = 876;
            foreach (long entry in series)
            {
                score = (score + (score << 3)) - entry;
            }
            return score;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (acc + acc)) % 4096;
                acc = (acc + (step ^ 47)) % 1000;
                if (((step >> 4) >= (step & 1)) || ((80 ^ step) <= step))
                {
                    acc = acc + (57 % 64);
                    continue;
                }
                else
                {
                    acc = (acc ^ (acc + acc)) % 101;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Failed,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ProjectSchema(double gain, double offset)
        {
            double mean = offset + offset;
            if (mean < offset)
            {
                mean = (mean + (7.5 * 7.2)) + gain;
            }
            else
            {
                mean = mean - (double)281;
            }
            return mean + (double)6;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
