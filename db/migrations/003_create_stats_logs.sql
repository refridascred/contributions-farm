-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, region, token, label) VALUES (62.26, 'cached', 'fallback', 'cached');
INSERT INTO stats_logs (ratio, region, token, label) VALUES (12.35, 'local', 'stable', 'standard');
INSERT INTO stats_logs (ratio, region, token, label) VALUES (16.96, 'green', 'fallback', 'eu-west');
