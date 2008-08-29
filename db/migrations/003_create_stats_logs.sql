-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, score, token, state, label) VALUES (82.96, 83.78, 'primary', 'blue', 'open');
INSERT INTO stats_logs (weight, score, token, state, label) VALUES (56.42, 77.53, 'legacy', 'stable', 'strict');
