-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_active ON cluster_logs (active);
