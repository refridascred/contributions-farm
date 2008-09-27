-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (count, score, state, label, active) VALUES (36, 20.82, 'eu-west', 'primary', 97);
INSERT INTO stats_logs (count, score, state, label, active) VALUES (12, 23.25, 'standard', 'cached', 13);
INSERT INTO stats_logs (count, score, state, label, active) VALUES (67, 38.39, 'green', 'staging', 64);
