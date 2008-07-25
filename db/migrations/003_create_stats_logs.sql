-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (score, region, active, state, label) VALUES (85.08, 'cached', 97, 'blue', 'cached');
INSERT INTO stats_logs (score, region, active, state, label) VALUES (33.35, 'stable', 97, 'standard', 'strict');
