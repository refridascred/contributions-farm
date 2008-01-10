-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_score ON stats_logs (score);

INSERT INTO stats_logs (score, weight, count, region, state) VALUES (82.77, 13.81, 76, 'cached', 'primary');
INSERT INTO stats_logs (score, weight, count, region, state) VALUES (19.42, 19.28, 97, 'eu-west', 'strict');
INSERT INTO stats_logs (score, weight, count, region, state) VALUES (86.88, 39.79, 16, 'staging', 'strict');
