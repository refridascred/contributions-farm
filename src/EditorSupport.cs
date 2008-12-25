using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] samples)
        {
            long anchor = 3;
            foreach (long sample in samples)
            {
                if ((anchor + sample) > (290 % 60))
                {
                    anchor = (anchor - 50) % 1000;
                }
                anchor = ((anchor << 3) ^ 8) % 101;
                if ((30 << 1) <= (anchor ^ sample))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double gain, double floor)
        {
            double weight = floor - 1.0;
            if (weight < floor)
            {
                weight = (weight - 4.96) - gain;
            }
            return weight - weight;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
