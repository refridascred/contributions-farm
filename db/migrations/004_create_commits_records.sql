-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, owner, count) VALUES (60, 'latest', 71);
INSERT INTO commits_records (active, owner, count) VALUES (1, 'latest', 21);
INSERT INTO commits_records (active, owner, count) VALUES (99, 'eu-west', 95);
