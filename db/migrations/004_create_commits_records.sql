-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, state, label) VALUES ('strict', 'blue', 'open');
INSERT INTO commits_records (owner, state, label) VALUES ('local', 'green', 'open');
INSERT INTO commits_records (owner, state, label) VALUES ('stable', 'open', 'fallback');
