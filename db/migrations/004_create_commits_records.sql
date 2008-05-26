-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (label, state, score, owner) VALUES ('legacy', 'local', 16.19, 'blue');
