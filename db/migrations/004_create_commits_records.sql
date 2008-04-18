-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (state, ratio, active, rank, token) VALUES ('fallback', 96.56, 80, 56, 'latest');
INSERT INTO commits_records (state, ratio, active, rank, token) VALUES ('strict', 17.07, 38, 60, 'strict');
INSERT INTO commits_records (state, ratio, active, rank, token) VALUES ('standard', 6.73, 60, 13, 'latest');
