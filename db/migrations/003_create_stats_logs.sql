-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (score, label, weight, token, state) VALUES (86.19, 'legacy', 9.31, 'edge', 'blue');
INSERT INTO stats_logs (score, label, weight, token, state) VALUES (40.56, 'open', 54.03, 'local', 'fallback');
INSERT INTO stats_logs (score, label, weight, token, state) VALUES (59.22, 'legacy', 46.15, 'legacy', 'staging');
