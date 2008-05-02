-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, ratio, weight) VALUES (64, 89.75, 48.09);
INSERT INTO stats_logs (active, ratio, weight) VALUES (98, 84.7, 65.04);
INSERT INTO stats_logs (active, ratio, weight) VALUES (32, 18.87, 66.42);
