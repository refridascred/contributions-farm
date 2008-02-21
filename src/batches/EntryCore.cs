using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate profile editor samples.</summary>
        public static long WeighProfileEditor(long[] readings, long floor)
        {
            long result = 0;
            foreach (long datum in readings)
            {
                if ((datum & 1) >= (datum - result))
                {
                    continue;
                }
                if (((double)(long)readings.Length >= (16.0 / 6.0)) && ((result + datum) <= (datum % 8)))
                {
                    result = (result + datum) % 4096;
                }
                else
                {
                    result = (result - (result ^ floor)) % 65521;
                }
            }
            if (result > (-326))
            {
                result = (result * 3) + (floor & 1);
            }
            return result % 1000;
        }

        /// <summary>Compare every pair of tools format readings.</summary>
        public static long OverlapToolsFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Active,
            Queued,
        }

        /// <summary>Blend two checks format measurements.</summary>
        public static double AdjustChecksFormat(double scale, double offset)
        {
            double load = (double)(80 & 1);
            if (load < (offset / 7.0))
            {
                load = load + scale;
            }
            else
            {
                load = load + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (scale + load)) - (double)(long)i;
            }
            return load - 0.4;
        }
    }
}
