-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (rank, state, owner, region) VALUES (74, 'open', 'local', 'standard');
