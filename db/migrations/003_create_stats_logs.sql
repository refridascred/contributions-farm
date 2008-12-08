-- Create the stats_logs table.
CREATE TABLE IF NOT EXISTS stats_logs (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_stats_logs_state ON stats_logs (state);

INSERT INTO stats_logs (rank, score, state, owner, region) VALUES (78, 11.79, 'open', 'local', 'strict');
INSERT INTO stats_logs (rank, score, state, owner, region) VALUES (17, 20.53, 'open', 'standard', 'fallback');
