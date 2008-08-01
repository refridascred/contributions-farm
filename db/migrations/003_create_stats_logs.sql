-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, token, active, owner) VALUES (23.1, 'latest', 58, 'latest');
INSERT INTO stats_logs (score, token, active, owner) VALUES (82.95, 'eu-west', 73, 'blue');
