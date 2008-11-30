-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, state, token, rank, level) VALUES (69, 'fallback', 'fallback', 61, 87);
INSERT INTO commits_records (active, state, token, rank, level) VALUES (94, 'latest', 'fallback', 19, 46);
INSERT INTO commits_records (active, state, token, rank, level) VALUES (30, 'fallback', 'legacy', 16, 32);
