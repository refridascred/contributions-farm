-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_active ON cluster_logs (active);

INSERT INTO cluster_logs (active, score, rank) VALUES (67, 79.73, 29);
INSERT INTO cluster_logs (active, score, rank) VALUES (41, 70.7, 55);
