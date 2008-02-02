-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, ratio, state) VALUES ('legacy', 87.52, 'standard');
INSERT INTO stats_logs (token, ratio, state) VALUES ('edge', 48.15, 'staging');
INSERT INTO stats_logs (token, ratio, state) VALUES ('stable', 70.9, 'cached');
