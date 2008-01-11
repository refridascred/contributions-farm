-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, score, state, owner) VALUES (83, 43.05, 'green', 'stable');
INSERT INTO commits_records (rank, score, state, owner) VALUES (37, 5.54, 'stable', 'blue');
INSERT INTO commits_records (rank, score, state, owner) VALUES (45, 90.07, 'staging', 'fallback');
