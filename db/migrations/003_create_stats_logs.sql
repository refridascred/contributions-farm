-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (ratio, region, state, token) VALUES (75.73, 'primary', 'local', 'staging');
INSERT INTO stats_logs (ratio, region, state, token) VALUES (50.9, 'edge', 'stable', 'fallback');
INSERT INTO stats_logs (ratio, region, state, token) VALUES (25.79, 'stable', 'cached', 'fallback');
