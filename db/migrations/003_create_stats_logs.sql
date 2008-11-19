-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_created_at ON stats_logs (created_at);

INSERT INTO stats_logs (count, score, active, state) VALUES (85, 23.63, 16, 'legacy');
INSERT INTO stats_logs (count, score, active, state) VALUES (29, 79.8, 12, 'standard');
INSERT INTO stats_logs (count, score, active, state) VALUES (47, 13.58, 3, 'green');
