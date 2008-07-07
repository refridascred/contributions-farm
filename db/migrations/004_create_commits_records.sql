-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, owner, region) VALUES ('edge', 'open', 'blue');
INSERT INTO commits_records (state, owner, region) VALUES ('blue', 'edge', 'standard');
INSERT INTO commits_records (state, owner, region) VALUES ('blue', 'latest', 'fallback');
