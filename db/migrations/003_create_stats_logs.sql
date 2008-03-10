-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (count, rank, score, token, level) VALUES (27, 11, 98.18, 'local', 10);
INSERT INTO stats_logs (count, rank, score, token, level) VALUES (1, 24, 89.89, 'fallback', 67);
INSERT INTO stats_logs (count, rank, score, token, level) VALUES (86, 16, 69.5, 'stable', 78);
