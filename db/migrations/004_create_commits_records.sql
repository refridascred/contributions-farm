-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (owner, weight, state, token) VALUES ('standard', 41.55, 'staging', 'cached');
INSERT INTO commits_records (owner, weight, state, token) VALUES ('latest', 18.08, 'stable', 'standard');
INSERT INTO commits_records (owner, weight, state, token) VALUES ('legacy', 37.08, 'green', 'standard');
