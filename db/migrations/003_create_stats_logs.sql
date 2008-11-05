-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, label, ratio) VALUES (17.99, 'latest', 6.32);
INSERT INTO stats_logs (score, label, ratio) VALUES (33.46, 'local', 3.15);
INSERT INTO stats_logs (score, label, ratio) VALUES (16.1, 'legacy', 80.05);
