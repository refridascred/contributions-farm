-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, region, label) VALUES (3.09, 'local', 'standard');
INSERT INTO stats_logs (ratio, region, label) VALUES (40.38, 'cached', 'open');
INSERT INTO stats_logs (ratio, region, label) VALUES (87.48, 'blue', 'eu-west');
