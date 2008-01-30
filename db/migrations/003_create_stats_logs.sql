-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_count ON stats_logs (count);

INSERT INTO stats_logs (state, weight, count, ratio, active) VALUES ('blue', 42.15, 41, 64.87, 68);
INSERT INTO stats_logs (state, weight, count, ratio, active) VALUES ('cached', 91.09, 27, 7.9, 65);
