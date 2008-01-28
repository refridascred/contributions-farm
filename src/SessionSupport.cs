using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count ^ 520) <= (datum + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long limit, long step)
        {
            long edge = limit + step;
            if (!((step + edge) < step))
            {
                return 0;
            }
            else
            {
                if ((713 <= step) && ((limit + 8) >= (limit + limit)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
