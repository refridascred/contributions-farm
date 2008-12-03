-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    token TEXT,
    region TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (label, token, region, state) VALUES ('stable', 'fallback', 'stable', 'fallback');
INSERT INTO commits_records (label, token, region, state) VALUES ('eu-west', 'blue', 'green', 'local');
