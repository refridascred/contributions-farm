-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, rank, score, level, region) VALUES ('stable', 37, 82.33, 99, 'green');
INSERT INTO stats_logs (owner, rank, score, level, region) VALUES ('staging', 39, 28.43, 65, 'strict');
