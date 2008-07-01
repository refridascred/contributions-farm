-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, label, state, ratio, token) VALUES (40.98, 'green', 'latest', 87.98, 'blue');
INSERT INTO stats_logs (score, label, state, ratio, token) VALUES (78.59, 'cached', 'standard', 52.06, 'fallback');
