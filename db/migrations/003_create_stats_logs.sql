-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (ratio, region, state, level) VALUES (50.04, 'primary', 'green', 75);
INSERT INTO stats_logs (ratio, region, state, level) VALUES (9.83, 'strict', 'fallback', 95);
