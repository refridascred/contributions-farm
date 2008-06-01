-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (level, label, score, count, rank) VALUES (11, 'stable', 19.43, 94, 96);
INSERT INTO stats_logs (level, label, score, count, rank) VALUES (55, 'open', 3.32, 83, 98);
