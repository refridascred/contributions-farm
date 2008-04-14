-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, count, active) VALUES (49.89, 51, 54);
INSERT INTO stats_logs (weight, count, active) VALUES (15.39, 13, 91);
INSERT INTO stats_logs (weight, count, active) VALUES (42.32, 88, 30);
