-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, region, owner, token) VALUES (70.56, 'cached', 'open', 'green');
INSERT INTO stats_logs (score, region, owner, token) VALUES (37.12, 'staging', 'latest', 'staging');
INSERT INTO stats_logs (score, region, owner, token) VALUES (24.17, 'legacy', 'stable', 'stable');
