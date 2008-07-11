-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (region, level, state) VALUES ('staging', 15, 'edge');
INSERT INTO stats_logs (region, level, state) VALUES ('fallback', 88, 'strict');
INSERT INTO stats_logs (region, level, state) VALUES ('strict', 36, 'stable');
