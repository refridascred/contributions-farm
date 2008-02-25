-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_token ON stats_logs (token);

INSERT INTO stats_logs (token, state, weight, ratio, score) VALUES ('eu-west', 'local', 96.5, 0.68, 56.85);
INSERT INTO stats_logs (token, state, weight, ratio, score) VALUES ('standard', 'cached', 97.37, 89.4, 68.93);
