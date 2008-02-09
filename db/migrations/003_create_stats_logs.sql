-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (count, weight, state) VALUES (11, 98.89, 'strict');
INSERT INTO stats_logs (count, weight, state) VALUES (61, 88.38, 'cached');
INSERT INTO stats_logs (count, weight, state) VALUES (6, 89.03, 'primary');
