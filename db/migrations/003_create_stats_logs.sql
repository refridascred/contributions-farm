-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (weight, ratio, owner, rank, score) VALUES (94.1, 85.56, 'primary', 73, 74.21);
INSERT INTO stats_logs (weight, ratio, owner, rank, score) VALUES (96.16, 12.45, 'blue', 37, 58.02);
