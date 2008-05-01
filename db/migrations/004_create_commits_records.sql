-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, owner, token, active, state) VALUES (67, 'eu-west', 'blue', 25, 'fallback');
INSERT INTO commits_records (rank, owner, token, active, state) VALUES (14, 'primary', 'green', 33, 'local');
INSERT INTO commits_records (rank, owner, token, active, state) VALUES (85, 'cached', 'strict', 67, 'local');
