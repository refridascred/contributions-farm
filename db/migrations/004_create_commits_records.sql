-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (active, count, token, owner) VALUES (46, 88, 'staging', 'legacy');
INSERT INTO commits_records (active, count, token, owner) VALUES (0, 6, 'latest', 'legacy');
INSERT INTO commits_records (active, count, token, owner) VALUES (97, 90, 'primary', 'legacy');
