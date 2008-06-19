-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_region ON cluster_logs (region);

INSERT INTO cluster_logs (label, region, ratio, count, rank) VALUES ('staging', 'latest', 16.95, 99, 15);
INSERT INTO cluster_logs (label, region, ratio, count, rank) VALUES ('latest', 'open', 71.25, 39, 32);
INSERT INTO cluster_logs (label, region, ratio, count, rank) VALUES ('green', 'stable', 9.13, 76, 49);
