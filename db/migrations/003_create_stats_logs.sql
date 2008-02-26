-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_level ON stats_logs (level);

INSERT INTO stats_logs (owner, weight, score, level, active) VALUES ('latest', 19.04, 80.38, 55, 19);
INSERT INTO stats_logs (owner, weight, score, level, active) VALUES ('legacy', 92.41, 39.12, 7, 54);
INSERT INTO stats_logs (owner, weight, score, level, active) VALUES ('fallback', 55.13, 4.38, 34, 66);
