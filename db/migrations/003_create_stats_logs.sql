-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, region, state) VALUES (9.35, 'strict', 'staging');
INSERT INTO stats_logs (ratio, region, state) VALUES (92.03, 'stable', 'fallback');
INSERT INTO stats_logs (ratio, region, state) VALUES (31.8, 'latest', 'latest');
