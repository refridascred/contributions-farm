-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (count, owner, token, region) VALUES (85, 'open', 'cached', 'cached');
INSERT INTO commits_records (count, owner, token, region) VALUES (54, 'open', 'legacy', 'legacy');
