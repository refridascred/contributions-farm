-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, owner, state, region) VALUES ('standard', 'standard', 'blue', 'eu-west');
INSERT INTO commits_records (label, owner, state, region) VALUES ('blue', 'legacy', 'edge', 'legacy');
INSERT INTO commits_records (label, owner, state, region) VALUES ('legacy', 'standard', 'fallback', 'standard');
