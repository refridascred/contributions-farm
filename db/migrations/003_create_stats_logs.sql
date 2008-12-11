-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, state, region, level, owner) VALUES (37.17, 'blue', 'primary', 84, 'legacy');
INSERT INTO stats_logs (ratio, state, region, level, owner) VALUES (47.56, 'primary', 'green', 45, 'local');
INSERT INTO stats_logs (ratio, state, region, level, owner) VALUES (92.03, 'edge', 'open', 22, 'edge');
