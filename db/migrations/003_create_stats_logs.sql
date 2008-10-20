-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (score, owner, count, token, region) VALUES (57.93, 'staging', 10, 'stable', 'strict');
INSERT INTO stats_logs (score, owner, count, token, region) VALUES (10.55, 'stable', 94, 'cached', 'standard');
INSERT INTO stats_logs (score, owner, count, token, region) VALUES (85.96, 'eu-west', 84, 'primary', 'strict');
