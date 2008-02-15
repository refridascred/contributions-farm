-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (active, region, label, level) VALUES (41, 'staging', 'fallback', 44);
INSERT INTO stats_logs (active, region, label, level) VALUES (25, 'stable', 'cached', 70);
INSERT INTO stats_logs (active, region, label, level) VALUES (57, 'fallback', 'staging', 55);
