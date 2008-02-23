-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (label, weight, ratio) VALUES ('edge', 0.91, 52.82);
INSERT INTO stats_logs (label, weight, ratio) VALUES ('stable', 39.61, 1.89);
INSERT INTO stats_logs (label, weight, ratio) VALUES ('stable', 43.01, 91.83);
