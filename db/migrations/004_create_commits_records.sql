-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (count, token, owner) VALUES (93, 'blue', 'blue');
INSERT INTO commits_records (count, token, owner) VALUES (20, 'blue', 'standard');
INSERT INTO commits_records (count, token, owner) VALUES (69, 'fallback', 'primary');
