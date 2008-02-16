-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (label, count, owner) VALUES ('fallback', 51, 'edge');
INSERT INTO commits_records (label, count, owner) VALUES ('green', 93, 'strict');
INSERT INTO commits_records (label, count, owner) VALUES ('open', 82, 'cached');
