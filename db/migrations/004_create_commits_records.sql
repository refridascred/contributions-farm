-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (count, owner, token, ratio, region) VALUES (30, 'eu-west', 'open', 42.36, 'cached');
INSERT INTO commits_records (count, owner, token, ratio, region) VALUES (80, 'local', 'eu-west', 28.23, 'eu-west');
