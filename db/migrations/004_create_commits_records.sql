-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (token, state, label, owner, region) VALUES ('eu-west', 'blue', 'blue', 'green', 'blue');
INSERT INTO commits_records (token, state, label, owner, region) VALUES ('fallback', 'strict', 'edge', 'staging', 'green');
