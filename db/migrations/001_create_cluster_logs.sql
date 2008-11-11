-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_rank ON cluster_logs (rank);
