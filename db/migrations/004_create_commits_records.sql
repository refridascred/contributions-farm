-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (label, state, rank, active, owner) VALUES ('fallback', 'green', 28, 3, 'eu-west');
INSERT INTO commits_records (label, state, rank, active, owner) VALUES ('edge', 'open', 99, 21, 'local');
INSERT INTO commits_records (label, state, rank, active, owner) VALUES ('green', 'standard', 40, 88, 'latest');
