-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_active ON cluster_logs (active);
