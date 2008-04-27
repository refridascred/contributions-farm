-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (state, token, score, label) VALUES ('strict', 'legacy', 0.79, 'edge');
INSERT INTO stats_logs (state, token, score, label) VALUES ('eu-west', 'cached', 88.28, 'stable');
