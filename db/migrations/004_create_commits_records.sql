-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (count, region, state, label, owner) VALUES (14, 'primary', 'standard', 'standard', 'blue');
INSERT INTO commits_records (count, region, state, label, owner) VALUES (38, 'legacy', 'open', 'fallback', 'edge');
INSERT INTO commits_records (count, region, state, label, owner) VALUES (3, 'open', 'local', 'primary', 'local');
