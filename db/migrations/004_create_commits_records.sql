-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (token, level, state, label) VALUES ('edge', 31, 'local', 'local');
INSERT INTO commits_records (token, level, state, label) VALUES ('fallback', 77, 'green', 'local');
INSERT INTO commits_records (token, level, state, label) VALUES ('primary', 35, 'fallback', 'staging');
