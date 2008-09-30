-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (weight, ratio, token, state) VALUES (47.63, 43.19, 'staging', 'standard');
INSERT INTO stats_logs (weight, ratio, token, state) VALUES (58.07, 47.18, 'latest', 'fallback');
