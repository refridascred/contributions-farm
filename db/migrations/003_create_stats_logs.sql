-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, region, state) VALUES (72.77, 'edge', 'stable');
INSERT INTO stats_logs (ratio, region, state) VALUES (22.43, 'edge', 'strict');
INSERT INTO stats_logs (ratio, region, state) VALUES (21.07, 'open', 'fallback');
