-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (active, level, count, score, owner) VALUES (36, 83, 36, 17.63, 'fallback');
INSERT INTO stats_logs (active, level, count, score, owner) VALUES (94, 52, 99, 40.31, 'open');
INSERT INTO stats_logs (active, level, count, score, owner) VALUES (21, 18, 85, 83.38, 'stable');
