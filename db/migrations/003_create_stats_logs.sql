-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, region, active, owner, token) VALUES (67, 'stable', 43, 'local', 'open');
INSERT INTO stats_logs (level, region, active, owner, token) VALUES (68, 'local', 18, 'stable', 'local');
