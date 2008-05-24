-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (active, level, region, label) VALUES (56, 24, 'cached', 'fallback');
INSERT INTO stats_logs (active, level, region, label) VALUES (48, 77, 'open', 'staging');
INSERT INTO stats_logs (active, level, region, label) VALUES (62, 41, 'fallback', 'edge');
