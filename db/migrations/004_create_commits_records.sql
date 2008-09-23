-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (score, state, token, level) VALUES (73.95, 'edge', 'green', 2);
INSERT INTO commits_records (score, state, token, level) VALUES (24.74, 'eu-west', 'primary', 85);
