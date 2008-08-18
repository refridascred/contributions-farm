-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, state, level, region) VALUES (62.15, 'staging', 22, 'stable');
INSERT INTO stats_logs (ratio, state, level, region) VALUES (43.0, 'edge', 66, 'stable');
