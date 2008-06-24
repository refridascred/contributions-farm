-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (ratio, token, state, level) VALUES (58.65, 'standard', 'standard', 77);
INSERT INTO stats_logs (ratio, token, state, level) VALUES (23.09, 'stable', 'primary', 71);
INSERT INTO stats_logs (ratio, token, state, level) VALUES (62.44, 'local', 'strict', 28);
