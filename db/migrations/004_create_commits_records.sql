-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, label, token, state, region) VALUES ('green', 'latest', 'fallback', 'standard', 'standard');
INSERT INTO commits_records (owner, label, token, state, region) VALUES ('blue', 'green', 'edge', 'edge', 'standard');
