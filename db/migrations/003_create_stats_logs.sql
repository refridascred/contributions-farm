-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (token, score, rank, state, label) VALUES ('staging', 37.43, 69, 'strict', 'legacy');
INSERT INTO stats_logs (token, score, rank, state, label) VALUES ('fallback', 11.23, 59, 'fallback', 'fallback');
INSERT INTO stats_logs (token, score, rank, state, label) VALUES ('staging', 75.47, 68, 'strict', 'green');
