-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (token, label, score) VALUES ('green', 'primary', 79.75);
INSERT INTO stats_logs (token, label, score) VALUES ('edge', 'stable', 18.29);
INSERT INTO stats_logs (token, label, score) VALUES ('cached', 'cached', 97.78);
