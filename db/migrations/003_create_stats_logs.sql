-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (level, score, label) VALUES (69, 16.55, 'eu-west');
INSERT INTO stats_logs (level, score, label) VALUES (12, 77.06, 'legacy');
INSERT INTO stats_logs (level, score, label) VALUES (55, 79.92, 'green');
