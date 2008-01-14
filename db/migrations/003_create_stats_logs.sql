-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (ratio, state, label, score, owner) VALUES (45.85, 'stable', 'legacy', 12.66, 'green');
INSERT INTO stats_logs (ratio, state, label, score, owner) VALUES (11.11, 'eu-west', 'fallback', 89.41, 'standard');
INSERT INTO stats_logs (ratio, state, label, score, owner) VALUES (53.44, 'blue', 'edge', 63.99, 'edge');
