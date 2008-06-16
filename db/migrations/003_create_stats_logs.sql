-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (state, token, weight, label) VALUES ('fallback', 'stable', 37.05, 'cached');
INSERT INTO stats_logs (state, token, weight, label) VALUES ('edge', 'primary', 9.01, 'cached');
