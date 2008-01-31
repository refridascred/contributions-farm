-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (label, owner) VALUES ('blue', 'strict');
INSERT INTO commits_records (label, owner) VALUES ('staging', 'open');
INSERT INTO commits_records (label, owner) VALUES ('open', 'cached');
