-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (region, state, count, token) VALUES ('staging', 'edge', 92, 'strict');
INSERT INTO commits_records (region, state, count, token) VALUES ('latest', 'fallback', 2, 'local');
INSERT INTO commits_records (region, state, count, token) VALUES ('latest', 'cached', 21, 'green');
