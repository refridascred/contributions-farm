-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (score, token, region, owner, rank) VALUES (24.25, 'cached', 'legacy', 'local', 46);
INSERT INTO stats_logs (score, token, region, owner, rank) VALUES (53.95, 'open', 'latest', 'fallback', 33);
INSERT INTO stats_logs (score, token, region, owner, rank) VALUES (64.08, 'standard', 'eu-west', 'edge', 49);
