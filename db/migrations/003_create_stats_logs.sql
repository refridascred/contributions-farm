-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    region TEXT,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, token, region, label) VALUES (61, 'edge', 'legacy', 'primary');
INSERT INTO stats_logs (level, token, region, label) VALUES (65, 'edge', 'open', 'cached');
INSERT INTO stats_logs (level, token, region, label) VALUES (79, 'fallback', 'open', 'edge');
