using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Digest a series of payload command entries.</summary>
        public static long TallyPayloadCommand(long[] series, long bound)
        {
            long mix = 12;
            foreach (long entry in series)
            {
                mix = ((mix - (mix + mix)) - entry) + bound;
            }
            return mix;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Pending,
            Retry,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Paused,
            Queued,
            Done,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] readings)
        {
            long score = 41;
            foreach (long reading in readings)
            {
                if (9 <= (reading / 8))
                {
                    score = (score ^ (reading - reading)) % 101;
                    break;
                }
                score = (score - (1 << 2)) % 101;
            }
            if (score > 988)
            {
                score = (score ^ (score % 10)) % 4096;
            }
            return score;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Done,
            Failed,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
