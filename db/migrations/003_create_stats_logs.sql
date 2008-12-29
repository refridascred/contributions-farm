-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    level INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (ratio, region, state, level, token) VALUES (79.78, 'legacy', 'blue', 70, 'open');
INSERT INTO stats_logs (ratio, region, state, level, token) VALUES (18.28, 'staging', 'primary', 56, 'open');
