-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (level, state, label, token) VALUES (23, 'green', 'fallback', 'staging');
INSERT INTO commits_records (level, state, label, token) VALUES (50, 'local', 'latest', 'stable');
INSERT INTO commits_records (level, state, label, token) VALUES (10, 'green', 'blue', 'open');
