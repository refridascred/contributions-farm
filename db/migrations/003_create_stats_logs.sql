-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (active, weight, ratio, state) VALUES (31, 26.53, 45.03, 'strict');
INSERT INTO stats_logs (active, weight, ratio, state) VALUES (88, 54.56, 81.73, 'staging');
INSERT INTO stats_logs (active, weight, ratio, state) VALUES (84, 49.55, 52.17, 'latest');
