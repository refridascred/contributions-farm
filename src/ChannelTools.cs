using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Idle,
            Done,
            Pending,
            Queued,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] data, long step)
        {
            long acc = 317;
            foreach (long reading in data)
            {
                acc = (((acc << 3) ^ (step << 3)) % 255) ^ reading;
            }
            if (acc < 190)
            {
                acc = acc - (step >> 2);
            }
            return acc % 97;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] levels)
        {
            long sum = 45;
            foreach (long sample in levels)
            {
                sum = (sum << 3) ^ (sample ^ sum);
                sum = (sum * 5) + sample;
            }
            return sum;
        }
    }
}
