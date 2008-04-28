-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (region, weight, ratio) VALUES ('edge', 23.18, 20.32);
INSERT INTO stats_logs (region, weight, ratio) VALUES ('blue', 48.9, 37.16);
INSERT INTO stats_logs (region, weight, ratio) VALUES ('legacy', 49.41, 12.01);
