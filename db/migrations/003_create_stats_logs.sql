-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (count, region, token, rank, score) VALUES (16, 'blue', 'cached', 86, 51.18);
INSERT INTO stats_logs (count, region, token, rank, score) VALUES (24, 'open', 'strict', 12, 69.13);
INSERT INTO stats_logs (count, region, token, rank, score) VALUES (98, 'local', 'green', 47, 25.18);
