-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (score, state, count, level) VALUES (75.7, 'latest', 51, 27);
INSERT INTO commits_records (score, state, count, level) VALUES (50.59, 'local', 80, 65);
INSERT INTO commits_records (score, state, count, level) VALUES (2.58, 'primary', 42, 80);
