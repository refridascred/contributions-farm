-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    level INTEGER,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (weight, level, rank, active, state) VALUES (40.09, 67, 65, 60, 'stable');
INSERT INTO stats_logs (weight, level, rank, active, state) VALUES (51.15, 19, 11, 59, 'cached');
INSERT INTO stats_logs (weight, level, rank, active, state) VALUES (74.28, 55, 84, 25, 'green');
