-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, count, label) VALUES ('standard', 7, 'legacy');
INSERT INTO commits_records (owner, count, label) VALUES ('fallback', 11, 'edge');
INSERT INTO commits_records (owner, count, label) VALUES ('legacy', 77, 'green');
