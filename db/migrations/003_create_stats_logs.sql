-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (count, state, score, active, label) VALUES (14, 'staging', 19.09, 16, 'latest');
INSERT INTO stats_logs (count, state, score, active, label) VALUES (10, 'primary', 42.85, 26, 'strict');
INSERT INTO stats_logs (count, state, score, active, label) VALUES (47, 'standard', 33.87, 27, 'legacy');
