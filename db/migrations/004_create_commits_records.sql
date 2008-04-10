-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (rank, state, owner, ratio, score) VALUES (28, 'staging', 'local', 81.41, 42.41);
INSERT INTO commits_records (rank, state, owner, ratio, score) VALUES (82, 'local', 'local', 31.35, 77.25);
