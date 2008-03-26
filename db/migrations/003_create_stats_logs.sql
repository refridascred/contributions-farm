-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (token, score, rank, weight) VALUES ('cached', 58.99, 62, 29.06);
INSERT INTO stats_logs (token, score, rank, weight) VALUES ('stable', 98.28, 33, 16.48);
