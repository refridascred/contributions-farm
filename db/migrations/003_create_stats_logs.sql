-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (ratio, state, level) VALUES (21.01, 'strict', 15);
INSERT INTO stats_logs (ratio, state, level) VALUES (82.36, 'strict', 1);
INSERT INTO stats_logs (ratio, state, level) VALUES (61.44, 'staging', 35);
