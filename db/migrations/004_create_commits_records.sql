-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, state, rank, score, token) VALUES (63, 'staging', 5, 77.48, 'fallback');
INSERT INTO commits_records (active, state, rank, score, token) VALUES (21, 'primary', 29, 35.83, 'fallback');
INSERT INTO commits_records (active, state, rank, score, token) VALUES (40, 'legacy', 19, 93.27, 'edge');
