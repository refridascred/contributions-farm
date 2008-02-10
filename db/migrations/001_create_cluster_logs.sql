-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_active ON cluster_logs (active);

INSERT INTO cluster_logs (ratio, token, active) VALUES (9.78, 'blue', 48);
