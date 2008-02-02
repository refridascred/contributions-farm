-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, weight, state) VALUES ('fallback', 73.35, 'green');
INSERT INTO stats_logs (token, weight, state) VALUES ('strict', 8.19, 'fallback');
