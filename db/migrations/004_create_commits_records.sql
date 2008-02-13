-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, rank, state, owner) VALUES ('latest', 45, 'primary', 'staging');
INSERT INTO commits_records (token, rank, state, owner) VALUES ('staging', 35, 'cached', 'strict');
INSERT INTO commits_records (token, rank, state, owner) VALUES ('cached', 68, 'fallback', 'cached');
