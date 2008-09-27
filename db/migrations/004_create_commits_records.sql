-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (score, count, state) VALUES (22.69, 11, 'standard');
INSERT INTO commits_records (score, count, state) VALUES (94.36, 7, 'green');
INSERT INTO commits_records (score, count, state) VALUES (66.36, 76, 'primary');
