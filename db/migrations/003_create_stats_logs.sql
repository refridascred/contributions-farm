-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (token, state, region, score, active) VALUES ('local', 'edge', 'latest', 94.97, 36);
INSERT INTO stats_logs (token, state, region, score, active) VALUES ('fallback', 'latest', 'blue', 88.51, 23);
INSERT INTO stats_logs (token, state, region, score, active) VALUES ('cached', 'eu-west', 'primary', 45.73, 89);
