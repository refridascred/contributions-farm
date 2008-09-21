-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, label, weight) VALUES (27.14, 'stable', 60.67);
INSERT INTO stats_logs (score, label, weight) VALUES (6.0, 'open', 53.45);
INSERT INTO stats_logs (score, label, weight) VALUES (54.96, 'staging', 38.02);
