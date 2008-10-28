-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (rank, count, score, level, owner) VALUES (44, 37, 85.2, 63, 'open');
INSERT INTO stats_logs (rank, count, score, level, owner) VALUES (23, 25, 72.41, 98, 'cached');
INSERT INTO stats_logs (rank, count, score, level, owner) VALUES (40, 59, 22.48, 84, 'latest');
