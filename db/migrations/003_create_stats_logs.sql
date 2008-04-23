-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (level, token, owner, rank, region) VALUES (18, 'fallback', 'blue', 14, 'standard');
INSERT INTO stats_logs (level, token, owner, rank, region) VALUES (69, 'staging', 'standard', 74, 'legacy');
INSERT INTO stats_logs (level, token, owner, rank, region) VALUES (18, 'local', 'stable', 30, 'staging');
