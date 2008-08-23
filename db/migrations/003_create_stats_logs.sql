-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, weight, count, token, state) VALUES (64.26, 8.47, 68, 'cached', 'blue');
INSERT INTO stats_logs (score, weight, count, token, state) VALUES (10.61, 11.59, 59, 'edge', 'staging');
