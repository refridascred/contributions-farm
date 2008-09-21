-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (score, token, state, region) VALUES (64.84, 'strict', 'blue', 'open');
INSERT INTO stats_logs (score, token, state, region) VALUES (4.31, 'open', 'cached', 'fallback');
