-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    level INTEGER,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (owner, weight, level, ratio, count) VALUES ('stable', 56.83, 94, 13.56, 85);
INSERT INTO stats_logs (owner, weight, level, ratio, count) VALUES ('strict', 69.34, 19, 41.54, 46);
