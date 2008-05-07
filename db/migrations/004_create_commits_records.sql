-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (active, owner, token) VALUES (6, 'blue', 'green');
INSERT INTO commits_records (active, owner, token) VALUES (63, 'local', 'fallback');
INSERT INTO commits_records (active, owner, token) VALUES (43, 'green', 'primary');
