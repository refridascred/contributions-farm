-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    token TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (label, token, region, ratio) VALUES ('staging', 'cached', 'standard', 41.05);
INSERT INTO stats_logs (label, token, region, ratio) VALUES ('edge', 'staging', 'latest', 10.36);
INSERT INTO stats_logs (label, token, region, ratio) VALUES ('eu-west', 'staging', 'edge', 67.99);
