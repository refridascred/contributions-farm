-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_count ON cluster_logs (count);

INSERT INTO cluster_logs (count, token, level) VALUES (69, 'staging', 5);
INSERT INTO cluster_logs (count, token, level) VALUES (1, 'blue', 59);
INSERT INTO cluster_logs (count, token, level) VALUES (79, 'fallback', 75);
