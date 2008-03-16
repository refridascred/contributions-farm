-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (count, level, score, owner, rank) VALUES (29, 32, 35.63, 'edge', 47);
INSERT INTO stats_logs (count, level, score, owner, rank) VALUES (94, 79, 2.5, 'open', 94);
INSERT INTO stats_logs (count, level, score, owner, rank) VALUES (34, 36, 81.07, 'fallback', 49);
