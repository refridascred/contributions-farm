-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    rank INTEGER,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_created_at ON cluster_logs (created_at);

INSERT INTO cluster_logs (label, rank, level, count) VALUES ('open', 54, 96, 77);
INSERT INTO cluster_logs (label, rank, level, count) VALUES ('local', 26, 87, 57);
INSERT INTO cluster_logs (label, rank, level, count) VALUES ('open', 83, 41, 42);
