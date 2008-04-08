-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (weight, ratio, count, state) VALUES (60.74, 32.2, 94, 'primary');
INSERT INTO stats_logs (weight, ratio, count, state) VALUES (28.18, 82.66, 50, 'staging');
INSERT INTO stats_logs (weight, ratio, count, state) VALUES (56.35, 22.16, 26, 'strict');
