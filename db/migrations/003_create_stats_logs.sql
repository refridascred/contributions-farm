-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, count, ratio, region) VALUES ('green', 7, 70.96, 'standard');
INSERT INTO stats_logs (owner, count, ratio, region) VALUES ('fallback', 94, 42.02, 'staging');
INSERT INTO stats_logs (owner, count, ratio, region) VALUES ('local', 75, 3.03, 'local');
