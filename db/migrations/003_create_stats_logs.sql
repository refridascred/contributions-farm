-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (label, ratio, weight) VALUES ('standard', 78.79, 28.11);
INSERT INTO stats_logs (label, ratio, weight) VALUES ('open', 96.41, 84.64);
INSERT INTO stats_logs (label, ratio, weight) VALUES ('standard', 85.86, 62.27);
