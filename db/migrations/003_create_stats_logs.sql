-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (score, state, ratio, count) VALUES (83.67, 'fallback', 23.93, 42);
INSERT INTO stats_logs (score, state, ratio, count) VALUES (67.06, 'blue', 94.52, 97);
INSERT INTO stats_logs (score, state, ratio, count) VALUES (79.32, 'staging', 23.53, 74);
