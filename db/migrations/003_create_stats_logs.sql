-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, label, weight, level) VALUES (58.0, 'latest', 70.11, 19);
INSERT INTO stats_logs (score, label, weight, level) VALUES (9.99, 'eu-west', 81.0, 60);
