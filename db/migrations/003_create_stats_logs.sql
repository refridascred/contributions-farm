-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_active ON stats_logs (active);

INSERT INTO stats_logs (region, score, token, weight, active) VALUES ('cached', 7.05, 'standard', 45.26, 56);
INSERT INTO stats_logs (region, score, token, weight, active) VALUES ('green', 72.76, 'blue', 78.44, 32);
INSERT INTO stats_logs (region, score, token, weight, active) VALUES ('staging', 79.21, 'stable', 87.68, 16);
