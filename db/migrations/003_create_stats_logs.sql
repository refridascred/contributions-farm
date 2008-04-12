-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (count, rank, region, score, owner) VALUES (37, 76, 'green', 75.0, 'latest');
INSERT INTO stats_logs (count, rank, region, score, owner) VALUES (65, 4, 'fallback', 96.06, 'fallback');
INSERT INTO stats_logs (count, rank, region, score, owner) VALUES (1, 3, 'latest', 27.99, 'cached');
