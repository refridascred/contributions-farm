-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (region, owner, active, token) VALUES ('open', 'stable', 86, 'green');
INSERT INTO stats_logs (region, owner, active, token) VALUES ('fallback', 'latest', 94, 'latest');
