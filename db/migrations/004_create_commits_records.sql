-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (owner, state, token, count) VALUES ('eu-west', 'fallback', 'open', 59);
INSERT INTO commits_records (owner, state, token, count) VALUES ('primary', 'green', 'cached', 20);
