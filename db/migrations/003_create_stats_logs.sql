-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_owner ON stats_logs (owner);

INSERT INTO stats_logs (owner, level, ratio, score, count) VALUES ('stable', 90, 83.84, 55.51, 69);
INSERT INTO stats_logs (owner, level, ratio, score, count) VALUES ('primary', 2, 20.99, 77.3, 41);
INSERT INTO stats_logs (owner, level, ratio, score, count) VALUES ('standard', 35, 40.85, 97.21, 80);
