-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, count, active) VALUES (85.33, 82, 91);
INSERT INTO stats_logs (weight, count, active) VALUES (35.23, 87, 54);
INSERT INTO stats_logs (weight, count, active) VALUES (5.86, 7, 51);
