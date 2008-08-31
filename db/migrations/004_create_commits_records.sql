-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, state) VALUES ('blue', 'stable');
INSERT INTO commits_records (owner, state) VALUES ('edge', 'open');
INSERT INTO commits_records (owner, state) VALUES ('green', 'fallback');
