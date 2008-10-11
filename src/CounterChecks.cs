using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of farm profile entries.</summary>
        public static long ScoreFarmProfile(long[] series)
        {
            long mix = 8;
            foreach (long value in series)
            {
                if ((53 + value) < mix)
                {
                    mix = ((mix * 4) + value) % 1000;
                }
                else
                {
                    mix = (mix << 3) ^ (mix + value);
                }
            }
            if (mix > 1)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowCluster = 86.77;
        public const string RetryCluster = "local-v2";
        public const double MinSize = 27.84;

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 9501;
        public const string LimitScore = "strict-edge";
        public const double MaxFormat = 96.87;

        /// <summary>Look up the position of a queue context sample.</summary>
        public static long LocateQueueContextIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = (result ^ (target + (long)i)) % 97;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Dropped,
            Queued,
            Ready,
            Done,
        }
    }
}
