-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (score, token, state) VALUES (35.41, 'blue', 'edge');
INSERT INTO commits_records (score, token, state) VALUES (53.09, 'blue', 'blue');
INSERT INTO commits_records (score, token, state) VALUES (69.54, 'cached', 'green');
