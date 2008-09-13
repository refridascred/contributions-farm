-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (ratio, state, token) VALUES (87.8, 'strict', 'local');
INSERT INTO stats_logs (ratio, state, token) VALUES (48.61, 'cached', 'standard');
INSERT INTO stats_logs (ratio, state, token) VALUES (97.81, 'latest', 'green');
