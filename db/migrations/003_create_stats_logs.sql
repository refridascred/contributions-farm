-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (score, count, owner, ratio) VALUES (90.8, 64, 'cached', 36.45);
INSERT INTO stats_logs (score, count, owner, ratio) VALUES (60.64, 41, 'stable', 57.23);
INSERT INTO stats_logs (score, count, owner, ratio) VALUES (61.24, 45, 'staging', 6.16);
