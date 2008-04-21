-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (score, label, token, ratio, state) VALUES (58.72, 'eu-west', 'open', 67.46, 'blue');
INSERT INTO stats_logs (score, label, token, ratio, state) VALUES (15.05, 'edge', 'stable', 98.3, 'edge');
