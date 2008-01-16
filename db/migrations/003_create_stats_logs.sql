-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (token, weight, score) VALUES ('green', 83.83, 35.83);
INSERT INTO stats_logs (token, weight, score) VALUES ('stable', 20.86, 67.46);
