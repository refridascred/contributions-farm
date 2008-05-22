-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (state, count, owner) VALUES ('latest', 96, 'fallback');
INSERT INTO commits_records (state, count, owner) VALUES ('latest', 42, 'blue');
INSERT INTO commits_records (state, count, owner) VALUES ('eu-west', 0, 'strict');
