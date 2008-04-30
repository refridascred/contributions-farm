-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (ratio, token, state) VALUES (54.93, 'legacy', 'strict');
INSERT INTO commits_records (ratio, token, state) VALUES (73.46, 'edge', 'standard');
INSERT INTO commits_records (ratio, token, state) VALUES (69.91, 'legacy', 'cached');
