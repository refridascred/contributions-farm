-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, ratio, region, level) VALUES (30.0, 9.0, 'primary', 94);
INSERT INTO stats_logs (weight, ratio, region, level) VALUES (89.74, 15.94, 'latest', 72);
INSERT INTO stats_logs (weight, ratio, region, level) VALUES (27.39, 93.09, 'legacy', 3);
