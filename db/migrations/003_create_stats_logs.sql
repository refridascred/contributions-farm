-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (count, level, weight, active) VALUES (65, 87, 84.42, 18);
INSERT INTO stats_logs (count, level, weight, active) VALUES (90, 52, 96.45, 95);
INSERT INTO stats_logs (count, level, weight, active) VALUES (13, 87, 70.74, 46);
