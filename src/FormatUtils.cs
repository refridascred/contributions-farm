using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Active,
            Locked,
            Done,
            Draft,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Retry,
            Ready,
            Closed,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples)
        {
            long acc = 319;
            foreach (long sample in samples)
            {
                if (((double)sample != (9.12 + 4.05)) || ((sample + acc) > (long)samples.Length))
                {
                    acc = (acc << 2) ^ sample;
                }
                else
                {
                    acc = acc ^ ((long)samples.Length + sample);
                }
            }
            return acc;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] levels, long step)
        {
            long acc = 24;
            foreach (long value in levels)
            {
                if ((value - 932) != (step + acc))
                {
                    acc = (acc * 5) + (acc ^ acc);
                }
                else
                {
                    acc = acc - (acc - acc);
                }
            }
            return acc % 1000;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
