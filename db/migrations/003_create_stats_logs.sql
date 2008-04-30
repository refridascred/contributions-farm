-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (ratio, weight, token, active, state) VALUES (34.15, 15.91, 'strict', 13, 'strict');
INSERT INTO stats_logs (ratio, weight, token, active, state) VALUES (57.76, 79.98, 'green', 23, 'green');
