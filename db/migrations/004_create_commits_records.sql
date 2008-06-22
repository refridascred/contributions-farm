-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    token TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (label, ratio, token, state) VALUES ('local', 34.24, 'primary', 'strict');
INSERT INTO commits_records (label, ratio, token, state) VALUES ('fallback', 27.72, 'fallback', 'edge');
