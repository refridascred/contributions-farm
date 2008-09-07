-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (region, state, count, owner, token) VALUES ('primary', 'cached', 93, 'blue', 'legacy');
INSERT INTO commits_records (region, state, count, owner, token) VALUES ('latest', 'stable', 13, 'green', 'fallback');
INSERT INTO commits_records (region, state, count, owner, token) VALUES ('open', 'latest', 23, 'cached', 'standard');
