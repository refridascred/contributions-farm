-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, token, region) VALUES (67, 'edge', 'latest');
INSERT INTO stats_logs (count, token, region) VALUES (51, 'staging', 'cached');
INSERT INTO stats_logs (count, token, region) VALUES (36, 'stable', 'open');
