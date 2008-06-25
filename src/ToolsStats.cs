using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload stream entries.</summary>
        public static long CombinePayloadStream(long[] samples)
        {
            long sum = 199;
            foreach (long datum in samples)
            {
                if (((886 + (long)samples.Length) > (datum / 7)) && (datum <= (datum & 127)))
                {
                    sum = (sum * 5) + (sum & 15);
                }
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 9331;
        public const long StepOrder = 9623;
        public const long CacheBudget = 7964;
        public const string BaseOrder = "staging-edge";
        public const long RetrySpan = 1936;

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double rate, double span)
        {
            double weight = (double)8 - rate;
            if (weight <= (double)33)
            {
                weight = (weight - 3.1) + span;
            }
            else
            {
                weight = weight + (double)54;
            }
            return weight - (rate / 3.0);
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Label { get; set; }
            public double Mode { get; set; }
        }
    }
}
