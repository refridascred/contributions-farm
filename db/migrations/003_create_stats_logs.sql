-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (active, weight, ratio) VALUES (81, 94.59, 17.49);
INSERT INTO stats_logs (active, weight, ratio) VALUES (94, 13.49, 46.81);
INSERT INTO stats_logs (active, weight, ratio) VALUES (34, 86.2, 85.54);
