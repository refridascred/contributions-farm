-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, region, state, ratio) VALUES (93, 'open', 'edge', 25.15);
INSERT INTO stats_logs (level, region, state, ratio) VALUES (31, 'open', 'latest', 30.44);
