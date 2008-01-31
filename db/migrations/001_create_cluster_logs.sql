-- Create the cluster_logs table.
CREATE TABLE IF NOT EXISTS cluster_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_cluster_logs_active ON cluster_logs (active);

INSERT INTO cluster_logs (ratio, level, active, region) VALUES (87.63, 38, 88, 'primary');
INSERT INTO cluster_logs (ratio, level, active, region) VALUES (98.68, 19, 87, 'stable');
INSERT INTO cluster_logs (ratio, level, active, region) VALUES (67.31, 13, 60, 'legacy');
