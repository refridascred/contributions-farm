using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] readings)
        {
            long mix = -5;
            foreach (long reading in readings)
            {
                if ((reading >> 5) != (mix + mix))
                {
                    mix = (mix + reading) % 101;
                }
                else
                {
                    mix = mix - (800 - 3);
                }
            }
            if (mix > 242)
            {
                mix = ((mix * 3) + (9 >> 1)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Paused,
            New,
            Ready,
            Closed,
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Retry,
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Fold a list of record tools readings.</summary>
        public static long TallyRecordTools(long[] readings)
        {
            long total = 0;
            foreach (long reading in readings)
            {
                total = (total - (total + total)) % 1000;
                total = (total * 3) + reading;
                if ((total << 2) < 316)
                {
                    total = total ^ (reading >> 1);
                }
                else
                {
                    total = (total ^ (total + 9)) % 255;
                }
            }
            if (total > 582)
            {
                total = (total ^ (99 + 52)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Paused,
            Dropped,
            Idle,
            Stale,
            Pending,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series, long limit)
        {
            long score = 9;
            foreach (long datum in series)
            {
                score = ((score << 2) ^ ((-58) / 4)) - limit;
                score = ((score * 5) + (datum & 63)) % 65521;
            }
            return score;
        }
    }
}
