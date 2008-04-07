-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, ratio, rank, label) VALUES (28.61, 76.37, 26, 'stable');
INSERT INTO stats_logs (weight, ratio, rank, label) VALUES (8.76, 96.04, 74, 'strict');
