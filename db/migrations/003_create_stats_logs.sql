-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (ratio, weight, state, active) VALUES (3.6, 75.07, 'legacy', 38);
INSERT INTO stats_logs (ratio, weight, state, active) VALUES (16.63, 20.36, 'cached', 58);
INSERT INTO stats_logs (ratio, weight, state, active) VALUES (63.42, 50.62, 'latest', 26);
