-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (owner, rank, state, label) VALUES ('fallback', 39, 'latest', 'open');
INSERT INTO commits_records (owner, rank, state, label) VALUES ('edge', 42, 'latest', 'cached');
INSERT INTO commits_records (owner, rank, state, label) VALUES ('strict', 0, 'stable', 'open');
