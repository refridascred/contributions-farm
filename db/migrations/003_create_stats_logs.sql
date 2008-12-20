-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, rank, label, region) VALUES (67.01, 9, 'local', 'legacy');
INSERT INTO stats_logs (weight, rank, label, region) VALUES (33.44, 41, 'green', 'strict');
