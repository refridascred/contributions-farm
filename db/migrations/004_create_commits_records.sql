-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, state, owner, token, ratio) VALUES (27, 'eu-west', 'latest', 'local', 12.94);
INSERT INTO commits_records (rank, state, owner, token, ratio) VALUES (98, 'edge', 'green', 'stable', 95.24);
