-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, token, state) VALUES ('primary', 'edge', 'fallback');
INSERT INTO commits_records (label, token, state) VALUES ('local', 'standard', 'blue');
INSERT INTO commits_records (label, token, state) VALUES ('primary', 'strict', 'blue');
