-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (count, ratio, region, label) VALUES (63, 14.95, 'local', 'eu-west');
INSERT INTO stats_logs (count, ratio, region, label) VALUES (7, 36.98, 'primary', 'primary');
INSERT INTO stats_logs (count, ratio, region, label) VALUES (38, 32.02, 'stable', 'blue');
