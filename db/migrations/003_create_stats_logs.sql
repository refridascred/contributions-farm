-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (token, score, level, owner) VALUES ('edge', 6.1, 16, 'strict');
INSERT INTO stats_logs (token, score, level, owner) VALUES ('strict', 67.16, 13, 'standard');
INSERT INTO stats_logs (token, score, level, owner) VALUES ('staging', 55.91, 41, 'staging');
