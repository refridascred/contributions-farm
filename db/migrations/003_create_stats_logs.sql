-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (weight, score, rank, region) VALUES (78.19, 87.15, 85, 'cached');
INSERT INTO stats_logs (weight, score, rank, region) VALUES (35.16, 50.06, 33, 'cached');
