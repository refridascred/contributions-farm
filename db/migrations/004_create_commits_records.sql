-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (owner, rank, state) VALUES ('staging', 85, 'latest');
INSERT INTO commits_records (owner, rank, state) VALUES ('fallback', 99, 'strict');
INSERT INTO commits_records (owner, rank, state) VALUES ('open', 96, 'open');
