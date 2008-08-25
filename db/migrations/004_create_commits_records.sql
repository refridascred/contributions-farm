-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (active, state, label, owner) VALUES (59, 'primary', 'latest', 'standard');
INSERT INTO commits_records (active, state, label, owner) VALUES (2, 'staging', 'green', 'blue');
INSERT INTO commits_records (active, state, label, owner) VALUES (26, 'cached', 'edge', 'cached');
