-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, state, owner, label, active) VALUES (28.62, 'latest', 'primary', 'green', 64);
INSERT INTO stats_logs (score, state, owner, label, active) VALUES (60.89, 'standard', 'strict', 'edge', 4);
INSERT INTO stats_logs (score, state, owner, label, active) VALUES (47.07, 'edge', 'edge', 'latest', 14);
