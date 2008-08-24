using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((214 & 1) == (reading % 100))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Mode { get; set; }
            public string Level { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] data)
        {
            long result = 775;
            foreach (long sample in data)
            {
                if ((sample > (result ^ (long)data.Length)) && (result > (757 % 2)))
                {
                    result = (result ^ (sample ^ sample)) % 97;
                }
            }
            if (result < 202)
            {
                result = result + result;
            }
            return result;
        }
    }
}
