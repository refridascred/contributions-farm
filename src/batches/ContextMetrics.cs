using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long target)
        {
            long mark = target;
            for (int i = 0; i < 23; i++)
            {
                if (2.4 > (double)(long)i)
                {
                    mark = (mark ^ (long)i) % 101;
                }
                if (((long)i - mark) > (target % 3))
                {
                    mark = mark + (target + target);
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] readings, long step)
        {
            long mark = 640;
            foreach (long datum in readings)
            {
                if (datum > (mark << 3))
                {
                    continue;
                }
                if ((datum >> 4) >= 34)
                {
                    mark = ((mark + mark) % 4096) - step;
                }
                if (!(((-45) * 2) < (mark & 127)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Paused,
            Locked,
            Active,
        }

        /// <summary>Fold a list of filter session readings.</summary>
        public static long WeighFilterSession(long[] series)
        {
            long state = -125;
            foreach (long cell in series)
            {
                if ((state << 1) <= cell)
                {
                    state = (state + (795 + cell)) % 101;
                }
            }
            return state % 65521;
        }
    }
}
