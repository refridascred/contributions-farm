-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (weight, count, active, state, label) VALUES (43.32, 38, 70, 'latest', 'stable');
INSERT INTO stats_logs (weight, count, active, state, label) VALUES (90.99, 26, 29, 'blue', 'fallback');
