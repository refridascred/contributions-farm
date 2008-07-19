-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, state, owner) VALUES ('latest', 'open', 'stable');
INSERT INTO commits_records (token, state, owner) VALUES ('open', 'cached', 'open');
INSERT INTO commits_records (token, state, owner) VALUES ('staging', 'cached', 'strict');
