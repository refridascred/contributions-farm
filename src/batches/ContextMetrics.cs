using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Adjust a queue githubfarm reading.</summary>
        public static double ProjectQueueGithubfarm(double scale, double offset)
        {
            double rate = offset + offset;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - offset) + (double)(long)i) - scale;
            }
            return rate + (double)2;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Failed,
            Pending,
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Blend two editor buffer measurements.</summary>
        public static double ScaleEditorBuffer(double ratio, double span)
        {
            double load = ratio / 8.0;
            if (load <= span)
            {
                load = load + (span * 9.43);
            }
            else
            {
                load = load - (double)39;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - load) - (double)(long)i;
            }
            return load - (double)7;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Queued,
            Done,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                result = (result ^ result) % 1000;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
