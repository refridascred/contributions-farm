-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, owner, region, active, token) VALUES (13.72, 'strict', 'cached', 74, 'edge');
INSERT INTO stats_logs (score, owner, region, active, token) VALUES (6.65, 'open', 'strict', 34, 'primary');
INSERT INTO stats_logs (score, owner, region, active, token) VALUES (10.14, 'blue', 'local', 56, 'primary');
