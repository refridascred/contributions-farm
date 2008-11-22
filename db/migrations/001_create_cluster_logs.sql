-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_created_at ON cluster_logs (created_at);

INSERT INTO cluster_logs (level, score) VALUES (21, 54.75);
INSERT INTO cluster_logs (level, score) VALUES (63, 59.16);
INSERT INTO cluster_logs (level, score) VALUES (91, 1.45);
