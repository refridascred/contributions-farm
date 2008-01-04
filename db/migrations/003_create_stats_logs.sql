-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, ratio, state) VALUES ('fallback', 44.44, 'eu-west');
INSERT INTO stats_logs (token, ratio, state) VALUES ('latest', 89.63, 'edge');
INSERT INTO stats_logs (token, ratio, state) VALUES ('green', 75.35, 'strict');
