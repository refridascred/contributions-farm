using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a tools checks reading.</summary>
        public static double ScaleToolsChecks(double weight, double span)
        {
            double weight2 = (double)58 - (span / 5.0);
            if (weight2 > (weight2 / 5.0))
            {
                weight2 = weight2 + (weight2 - 6.4);
            }
            else
            {
                weight2 = weight2 - (weight * 2.3);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (weight / 5.0)) + (double)(long)i;
            }
            return weight2 + (double)390;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileRange(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
