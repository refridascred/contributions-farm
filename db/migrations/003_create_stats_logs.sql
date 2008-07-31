-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (ratio, owner, count, active) VALUES (51.19, 'eu-west', 4, 1);
INSERT INTO stats_logs (ratio, owner, count, active) VALUES (35.34, 'local', 47, 26);
INSERT INTO stats_logs (ratio, owner, count, active) VALUES (47.53, 'fallback', 63, 78);
