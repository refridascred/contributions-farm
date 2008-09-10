-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (label, ratio, weight) VALUES ('legacy', 50.4, 0.01);
INSERT INTO stats_logs (label, ratio, weight) VALUES ('fallback', 49.54, 33.08);
INSERT INTO stats_logs (label, ratio, weight) VALUES ('legacy', 27.0, 0.6);
