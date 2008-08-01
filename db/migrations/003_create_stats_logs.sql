-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (weight, ratio, region) VALUES (8.14, 74.66, 'open');
INSERT INTO stats_logs (weight, ratio, region) VALUES (5.08, 93.44, 'blue');
INSERT INTO stats_logs (weight, ratio, region) VALUES (95.42, 25.14, 'local');
