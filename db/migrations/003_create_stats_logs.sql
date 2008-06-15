-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (count, active, rank, score, ratio) VALUES (7, 14, 94, 17.41, 75.26);
INSERT INTO stats_logs (count, active, rank, score, ratio) VALUES (85, 44, 61, 85.96, 28.15);
