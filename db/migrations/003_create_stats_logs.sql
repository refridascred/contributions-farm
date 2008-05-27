-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (weight, owner, active, count) VALUES (68.38, 'fallback', 70, 56);
INSERT INTO stats_logs (weight, owner, active, count) VALUES (91.52, 'stable', 7, 36);
INSERT INTO stats_logs (weight, owner, active, count) VALUES (28.38, 'cached', 99, 6);
