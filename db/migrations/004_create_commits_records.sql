-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (owner, state, rank, ratio) VALUES ('open', 'fallback', 46, 20.89);
INSERT INTO commits_records (owner, state, rank, ratio) VALUES ('green', 'strict', 92, 24.81);
