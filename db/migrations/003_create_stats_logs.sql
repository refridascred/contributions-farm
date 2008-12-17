-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (state, ratio, active, token) VALUES ('fallback', 59.82, 13, 'legacy');
INSERT INTO stats_logs (state, ratio, active, token) VALUES ('latest', 23.51, 52, 'eu-west');
