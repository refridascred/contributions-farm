-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (state, weight, token) VALUES ('primary', 53.1, 'green');
INSERT INTO stats_logs (state, weight, token) VALUES ('blue', 54.41, 'stable');
INSERT INTO stats_logs (state, weight, token) VALUES ('primary', 62.68, 'blue');
