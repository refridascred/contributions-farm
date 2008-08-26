-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, active, token) VALUES ('staging', 94, 'open');
INSERT INTO commits_records (owner, active, token) VALUES ('edge', 3, 'latest');
INSERT INTO commits_records (owner, active, token) VALUES ('legacy', 40, 'staging');
