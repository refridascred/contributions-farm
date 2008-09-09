-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (state, label) VALUES ('stable', 'standard');
INSERT INTO commits_records (state, label) VALUES ('fallback', 'standard');
INSERT INTO commits_records (state, label) VALUES ('standard', 'local');
