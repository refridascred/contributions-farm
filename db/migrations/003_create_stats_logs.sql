-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (token, score, weight, level) VALUES ('fallback', 83.94, 7.38, 69);
INSERT INTO stats_logs (token, score, weight, level) VALUES ('latest', 76.56, 27.81, 32);
