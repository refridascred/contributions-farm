-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (active, weight, ratio, rank, state) VALUES (78, 40.1, 73.61, 48, 'eu-west');
INSERT INTO stats_logs (active, weight, ratio, rank, state) VALUES (49, 56.91, 73.74, 48, 'eu-west');
INSERT INTO stats_logs (active, weight, ratio, rank, state) VALUES (2, 89.12, 49.43, 75, 'latest');
