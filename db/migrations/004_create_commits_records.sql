-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (score, state, owner) VALUES (73.19, 'stable', 'blue');
INSERT INTO commits_records (score, state, owner) VALUES (27.88, 'legacy', 'fallback');
INSERT INTO commits_records (score, state, owner) VALUES (33.62, 'stable', 'cached');
