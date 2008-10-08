-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, label, ratio, rank) VALUES (28.67, 'legacy', 23.69, 14);
INSERT INTO stats_logs (weight, label, ratio, rank) VALUES (17.87, 'staging', 65.65, 7);
INSERT INTO stats_logs (weight, label, ratio, rank) VALUES (43.14, 'green', 42.02, 99);
