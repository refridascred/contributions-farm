-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (active, owner, state) VALUES (43, 'open', 'staging');
INSERT INTO commits_records (active, owner, state) VALUES (92, 'standard', 'green');
INSERT INTO commits_records (active, owner, state) VALUES (33, 'edge', 'stable');
