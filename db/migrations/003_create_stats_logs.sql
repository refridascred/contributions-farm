-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (active, score, state, ratio) VALUES (5, 29.38, 'edge', 6.7);
INSERT INTO stats_logs (active, score, state, ratio) VALUES (79, 31.73, 'edge', 7.37);
INSERT INTO stats_logs (active, score, state, ratio) VALUES (4, 53.7, 'legacy', 75.38);
