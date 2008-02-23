-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (weight, count, state, ratio) VALUES (38.13, 89, 'staging', 6.43);
INSERT INTO stats_logs (weight, count, state, ratio) VALUES (25.28, 83, 'local', 51.89);
INSERT INTO stats_logs (weight, count, state, ratio) VALUES (65.29, 55, 'standard', 37.53);
