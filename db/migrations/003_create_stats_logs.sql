-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_weight ON stats_logs (weight);

INSERT INTO stats_logs (weight, state, count, owner) VALUES (90.58, 'edge', 68, 'open');
INSERT INTO stats_logs (weight, state, count, owner) VALUES (78.57, 'primary', 70, 'stable');
INSERT INTO stats_logs (weight, state, count, owner) VALUES (65.46, 'green', 3, 'cached');
