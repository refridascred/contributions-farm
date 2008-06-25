-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, label, region) VALUES (52.77, 'standard', 'blue');
INSERT INTO stats_logs (ratio, label, region) VALUES (7.03, 'staging', 'local');
INSERT INTO stats_logs (ratio, label, region) VALUES (95.35, 'fallback', 'cached');
