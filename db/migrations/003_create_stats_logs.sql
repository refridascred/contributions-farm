-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (level, region, state, label, token) VALUES (14, 'staging', 'strict', 'green', 'cached');
INSERT INTO stats_logs (level, region, state, label, token) VALUES (71, 'cached', 'edge', 'primary', 'edge');
