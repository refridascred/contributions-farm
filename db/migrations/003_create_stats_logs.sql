-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_ratio ON stats_logs (ratio);

INSERT INTO stats_logs (active, ratio, score, count, owner) VALUES (73, 11.18, 13.02, 26, 'standard');
INSERT INTO stats_logs (active, ratio, score, count, owner) VALUES (59, 33.15, 7.33, 84, 'stable');
INSERT INTO stats_logs (active, ratio, score, count, owner) VALUES (90, 44.0, 79.27, 48, 'staging');
