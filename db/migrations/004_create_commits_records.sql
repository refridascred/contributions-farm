-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    rank INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (state, rank, owner, count, token) VALUES ('standard', 77, 'open', 19, 'blue');
INSERT INTO commits_records (state, rank, owner, count, token) VALUES ('local', 2, 'fallback', 30, 'eu-west');
INSERT INTO commits_records (state, rank, owner, count, token) VALUES ('edge', 85, 'primary', 11, 'edge');
