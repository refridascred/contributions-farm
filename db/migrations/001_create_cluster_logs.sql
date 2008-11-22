-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_active ON cluster_logs (active);

INSERT INTO cluster_logs (ratio, score, active) VALUES (85.08, 2.22, 43);
INSERT INTO cluster_logs (ratio, score, active) VALUES (34.7, 43.07, 39);
