-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (ratio, token, state) VALUES (86.74, 'fallback', 'local');
INSERT INTO stats_logs (ratio, token, state) VALUES (43.25, 'blue', 'green');
INSERT INTO stats_logs (ratio, token, state) VALUES (37.83, 'standard', 'green');
