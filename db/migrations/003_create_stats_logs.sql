-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, level, ratio, owner, weight) VALUES (7.18, 45, 49.47, 'strict', 59.6);
INSERT INTO stats_logs (score, level, ratio, owner, weight) VALUES (17.51, 21, 30.35, 'open', 67.03);
