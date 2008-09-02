-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (ratio, owner, token, region) VALUES (4.65, 'latest', 'local', 'standard');
INSERT INTO stats_logs (ratio, owner, token, region) VALUES (95.17, 'open', 'staging', 'edge');
INSERT INTO stats_logs (ratio, owner, token, region) VALUES (76.28, 'fallback', 'legacy', 'local');
