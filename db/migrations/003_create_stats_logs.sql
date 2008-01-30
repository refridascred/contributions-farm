-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (weight, ratio, level) VALUES (26.37, 84.42, 14);
INSERT INTO stats_logs (weight, ratio, level) VALUES (37.22, 59.05, 1);
INSERT INTO stats_logs (weight, ratio, level) VALUES (50.87, 72.07, 88);
