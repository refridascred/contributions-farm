-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (score, state, region) VALUES (37.99, 'stable', 'latest');
INSERT INTO commits_records (score, state, region) VALUES (62.17, 'green', 'strict');
INSERT INTO commits_records (score, state, region) VALUES (94.14, 'staging', 'blue');
