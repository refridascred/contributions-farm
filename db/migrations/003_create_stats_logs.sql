-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (score, level, state) VALUES (40.19, 46, 'cached');
INSERT INTO stats_logs (score, level, state) VALUES (42.99, 37, 'open');
INSERT INTO stats_logs (score, level, state) VALUES (85.13, 59, 'staging');
