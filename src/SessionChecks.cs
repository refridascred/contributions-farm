using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Locked,
            Queued,
            Idle,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Size { get; set; } = "";
            public double Limit { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Level { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double ratio, double offset)
        {
            double load = offset + (double)94;
            for (int i = 0; i < 5; i++)
            {
                load = (load - (ratio * 1.78)) - (double)(long)i;
            }
            return load - (4.0 + load);
        }
    }
}
