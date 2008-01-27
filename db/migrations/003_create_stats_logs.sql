-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (region, state, token, active, ratio) VALUES ('cached', 'cached', 'local', 37, 62.87);
INSERT INTO stats_logs (region, state, token, active, ratio) VALUES ('latest', 'fallback', 'edge', 17, 15.9);
