-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (ratio, token, score, state) VALUES (67.43, 'edge', 11.43, 'latest');
INSERT INTO stats_logs (ratio, token, score, state) VALUES (20.64, 'eu-west', 1.66, 'blue');
