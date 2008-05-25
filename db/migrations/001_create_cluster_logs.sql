-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_ratio ON cluster_logs (ratio);

INSERT INTO cluster_logs (level, ratio, rank, active) VALUES (87, 68.14, 21, 0);
INSERT INTO cluster_logs (level, ratio, rank, active) VALUES (39, 40.39, 89, 24);
