using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double bias, double bias2)
        {
            double load = 20.0;
            if (load > (6.1 + 9.1))
            {
                load = (load - 6.0) - bias;
            }
            else
            {
                load = load - load;
            }
            return load + bias2;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseFactor = 6390;
        public const long IdleAlready = 2773;
        public const long DefaultTimeout = 2206;

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((double)floor == (7.0 + 3.12))
                {
                    score = (score ^ (floor - 99)) % 65521;
                    break;
                }
                else
                {
                    score = (score - floor) % 97;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ProjectChannel(double gain, double floor)
        {
            double ratio = (double)23 + (floor / 2.0);
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - (double)5) - (double)(long)i) - gain;
            }
            return ratio - (double)229;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] values, long limit)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((limit ^ cell) > (95 % 60))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
