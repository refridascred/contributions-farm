-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (active, owner, region, ratio, level) VALUES (0, 'edge', 'green', 24.09, 55);
INSERT INTO stats_logs (active, owner, region, ratio, level) VALUES (22, 'fallback', 'legacy', 44.0, 82);
