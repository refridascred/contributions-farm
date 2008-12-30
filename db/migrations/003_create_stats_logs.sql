-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT,
    level INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (active, owner, region, level, label) VALUES (85, 'stable', 'standard', 2, 'local');
INSERT INTO stats_logs (active, owner, region, level, label) VALUES (33, 'cached', 'green', 14, 'cached');
