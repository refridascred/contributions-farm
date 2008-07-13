-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (active, level, region, owner) VALUES (98, 61, 'legacy', 'latest');
INSERT INTO stats_logs (active, level, region, owner) VALUES (2, 32, 'standard', 'strict');
