-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, state, active, token) VALUES ('blue', 'stable', 53, 'eu-west');
INSERT INTO commits_records (owner, state, active, token) VALUES ('legacy', 'staging', 26, 'fallback');
