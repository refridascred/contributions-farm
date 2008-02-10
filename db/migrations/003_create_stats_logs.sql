-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (label, ratio, region, token) VALUES ('open', 6.9, 'staging', 'open');
INSERT INTO stats_logs (label, ratio, region, token) VALUES ('blue', 54.12, 'fallback', 'edge');
