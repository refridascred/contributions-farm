-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (owner, score, rank, token) VALUES ('stable', 47.48, 17, 'cached');
INSERT INTO stats_logs (owner, score, rank, token) VALUES ('standard', 14.53, 37, 'legacy');
