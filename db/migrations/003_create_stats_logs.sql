-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, count, region) VALUES (53.54, 28, 'cached');
INSERT INTO stats_logs (ratio, count, region) VALUES (46.33, 22, 'standard');
INSERT INTO stats_logs (ratio, count, region) VALUES (30.4, 15, 'legacy');
