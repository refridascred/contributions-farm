-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, weight, region) VALUES (45.58, 94.32, 'latest');
INSERT INTO stats_logs (ratio, weight, region) VALUES (10.08, 7.31, 'edge');
