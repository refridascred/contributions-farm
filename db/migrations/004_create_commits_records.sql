-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (count, state, active, token, region) VALUES (31, 'standard', 71, 'latest', 'edge');
INSERT INTO commits_records (count, state, active, token, region) VALUES (62, 'standard', 72, 'blue', 'open');
INSERT INTO commits_records (count, state, active, token, region) VALUES (23, 'latest', 26, 'legacy', 'cached');
