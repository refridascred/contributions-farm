-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (owner, rank, label, state) VALUES ('primary', 36, 'latest', 'local');
INSERT INTO commits_records (owner, rank, label, state) VALUES ('stable', 46, 'open', 'eu-west');
INSERT INTO commits_records (owner, rank, label, state) VALUES ('fallback', 77, 'stable', 'strict');
