-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, state, score) VALUES ('latest', 'fallback', 91.38);
INSERT INTO commits_records (owner, state, score) VALUES ('primary', 'primary', 14.87);
INSERT INTO commits_records (owner, state, score) VALUES ('standard', 'latest', 62.53);
