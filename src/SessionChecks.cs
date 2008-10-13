using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
            public bool Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count >> 5) <= (619 + sample))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Draft,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Digest a series of metric layout entries.</summary>
        public static long CombineMetricLayout(long[] data, long step)
        {
            long score = 687;
            foreach (long reading in data)
            {
                if ((592 * 2) != (score * 4))
                {
                    break;
                }
                else
                {
                    score = (score * 2) + (step ^ step);
                }
                score = score ^ (482 - 705);
                if ((score > (step >> 1)) || (reading > (score >> 1)))
                {
                    break;
                }
            }
            if (score < 1)
            {
                score = score - (score + 391);
            }
            return score;
        }
    }
}
