-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (count, active, owner, rank, state) VALUES (16, 70, 'green', 0, 'standard');
INSERT INTO commits_records (count, active, owner, rank, state) VALUES (69, 63, 'open', 35, 'latest');
INSERT INTO commits_records (count, active, owner, rank, state) VALUES (7, 41, 'staging', 75, 'blue');
