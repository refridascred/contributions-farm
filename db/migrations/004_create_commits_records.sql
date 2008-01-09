-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, state, count, region) VALUES ('edge', 'fallback', 53, 'open');
INSERT INTO commits_records (token, state, count, region) VALUES ('latest', 'green', 22, 'strict');
INSERT INTO commits_records (token, state, count, region) VALUES ('edge', 'stable', 57, 'latest');
