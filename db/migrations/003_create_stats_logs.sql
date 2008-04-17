-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, level, count) VALUES (81.48, 92, 49);
INSERT INTO stats_logs (score, level, count) VALUES (66.74, 87, 57);
INSERT INTO stats_logs (score, level, count) VALUES (41.24, 14, 61);
