-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_rank ON stats_logs (rank);

INSERT INTO stats_logs (score, token, weight, rank, region) VALUES (18.82, 'green', 84.39, 13, 'strict');
INSERT INTO stats_logs (score, token, weight, rank, region) VALUES (59.88, 'eu-west', 66.89, 32, 'strict');
