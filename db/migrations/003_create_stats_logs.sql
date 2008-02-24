-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (score, level, ratio, rank, owner) VALUES (57.32, 61, 61.95, 70, 'strict');
INSERT INTO stats_logs (score, level, ratio, rank, owner) VALUES (87.09, 54, 89.18, 11, 'latest');
