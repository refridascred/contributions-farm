-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (weight, label, score, token) VALUES (46.66, 'stable', 85.55, 'green');
INSERT INTO stats_logs (weight, label, score, token) VALUES (89.41, 'legacy', 30.55, 'local');
