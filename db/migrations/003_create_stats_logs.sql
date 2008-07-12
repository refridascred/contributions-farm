-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, weight, region) VALUES (62.0, 59.44, 'strict');
INSERT INTO stats_logs (ratio, weight, region) VALUES (44.96, 64.71, 'eu-west');
