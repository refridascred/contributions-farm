-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, state, label) VALUES ('staging', 'staging', 'primary');
INSERT INTO commits_records (owner, state, label) VALUES ('fallback', 'local', 'cached');
