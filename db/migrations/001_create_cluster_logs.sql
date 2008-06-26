-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_count ON cluster_logs (count);

INSERT INTO cluster_logs (level, weight, count) VALUES (27, 96.85, 89);
INSERT INTO cluster_logs (level, weight, count) VALUES (34, 11.76, 78);
