-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (count, state, owner) VALUES (13, 'strict', 'cached');
INSERT INTO commits_records (count, state, owner) VALUES (50, 'legacy', 'local');
INSERT INTO commits_records (count, state, owner) VALUES (14, 'green', 'strict');
