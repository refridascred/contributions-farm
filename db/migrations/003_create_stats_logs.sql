-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, active, token, weight, region) VALUES (72, 42, 'blue', 14.63, 'edge');
INSERT INTO stats_logs (rank, active, token, weight, region) VALUES (43, 31, 'fallback', 92.39, 'strict');
