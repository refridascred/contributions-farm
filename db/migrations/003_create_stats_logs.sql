-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    token TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, level, token, weight, active) VALUES (72.38, 89, 'local', 53.86, 55);
INSERT INTO stats_logs (score, level, token, weight, active) VALUES (50.16, 91, 'latest', 94.6, 74);
