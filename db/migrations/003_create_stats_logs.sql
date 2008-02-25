-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (level, score, rank, ratio, owner) VALUES (86, 95.77, 15, 13.86, 'stable');
INSERT INTO stats_logs (level, score, rank, ratio, owner) VALUES (96, 56.05, 53, 2.78, 'legacy');
