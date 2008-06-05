-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (active, ratio, region, weight) VALUES (75, 73.56, 'blue', 63.93);
INSERT INTO stats_logs (active, ratio, region, weight) VALUES (17, 64.87, 'staging', 10.45);
INSERT INTO stats_logs (active, ratio, region, weight) VALUES (21, 35.94, 'local', 88.24);
