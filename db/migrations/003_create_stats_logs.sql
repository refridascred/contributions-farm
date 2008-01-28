-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (rank, weight, token, score, region) VALUES (37, 74.37, 'strict', 29.92, 'standard');
INSERT INTO stats_logs (rank, weight, token, score, region) VALUES (88, 88.71, 'legacy', 18.75, 'cached');
INSERT INTO stats_logs (rank, weight, token, score, region) VALUES (79, 43.73, 'standard', 15.23, 'edge');
