-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (weight, count, active, owner) VALUES (12.59, 63, 67, 'open');
INSERT INTO stats_logs (weight, count, active, owner) VALUES (62.02, 80, 1, 'stable');
INSERT INTO stats_logs (weight, count, active, owner) VALUES (26.07, 93, 87, 'cached');
