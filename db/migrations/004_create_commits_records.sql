-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (label, owner, token, active) VALUES ('stable', 'eu-west', 'eu-west', 59);
INSERT INTO commits_records (label, owner, token, active) VALUES ('latest', 'local', 'latest', 93);
