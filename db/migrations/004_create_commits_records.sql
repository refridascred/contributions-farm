-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (ratio, count, state, owner) VALUES (94.88, 39, 'eu-west', 'open');
INSERT INTO commits_records (ratio, count, state, owner) VALUES (3.15, 11, 'standard', 'strict');
INSERT INTO commits_records (ratio, count, state, owner) VALUES (94.19, 79, 'primary', 'stable');
