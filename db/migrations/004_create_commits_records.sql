-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (label, token, state, owner) VALUES ('edge', 'open', 'open', 'eu-west');
INSERT INTO commits_records (label, token, state, owner) VALUES ('standard', 'eu-west', 'cached', 'blue');
INSERT INTO commits_records (label, token, state, owner) VALUES ('latest', 'strict', 'legacy', 'fallback');
