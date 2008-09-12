-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, label, token, count) VALUES (75.98, 'green', 'blue', 62);
INSERT INTO stats_logs (score, label, token, count) VALUES (14.27, 'cached', 'cached', 41);
INSERT INTO stats_logs (score, label, token, count) VALUES (8.0, 'edge', 'eu-west', 12);
