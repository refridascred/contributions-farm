-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (token, score, ratio) VALUES ('latest', 20.81, 66.47);
INSERT INTO stats_logs (token, score, ratio) VALUES ('standard', 82.95, 24.01);
