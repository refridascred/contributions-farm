-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (ratio, state, token) VALUES (68.64, 'staging', 'primary');
INSERT INTO commits_records (ratio, state, token) VALUES (46.49, 'cached', 'fallback');
