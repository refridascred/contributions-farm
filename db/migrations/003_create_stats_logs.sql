-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_label ON stats_logs (label);

INSERT INTO stats_logs (token, score, label) VALUES ('fallback', 71.89, 'standard');
INSERT INTO stats_logs (token, score, label) VALUES ('open', 67.4, 'edge');
INSERT INTO stats_logs (token, score, label) VALUES ('fallback', 72.83, 'blue');
