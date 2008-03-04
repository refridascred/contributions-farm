-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_region ON stats_logs (region);

INSERT INTO stats_logs (state, ratio, token, region) VALUES ('local', 67.21, 'fallback', 'cached');
INSERT INTO stats_logs (state, ratio, token, region) VALUES ('stable', 5.03, 'latest', 'open');
INSERT INTO stats_logs (state, ratio, token, region) VALUES ('edge', 68.32, 'edge', 'blue');
