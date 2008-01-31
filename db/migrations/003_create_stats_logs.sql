-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (token, owner, score, count) VALUES ('open', 'cached', 16.23, 83);
INSERT INTO stats_logs (token, owner, score, count) VALUES ('local', 'green', 26.57, 51);
INSERT INTO stats_logs (token, owner, score, count) VALUES ('stable', 'green', 27.01, 47);
