-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (state, score, label) VALUES ('cached', 60.9, 'edge');
INSERT INTO stats_logs (state, score, label) VALUES ('edge', 57.48, 'staging');
INSERT INTO stats_logs (state, score, label) VALUES ('cached', 93.5, 'stable');
