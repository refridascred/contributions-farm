-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (active, label, state) VALUES (76, 'open', 'cached');
INSERT INTO commits_records (active, label, state) VALUES (79, 'latest', 'standard');
INSERT INTO commits_records (active, label, state) VALUES (91, 'staging', 'strict');
