-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (count, region, token, owner, ratio) VALUES (0, 'eu-west', 'latest', 'open', 53.05);
INSERT INTO commits_records (count, region, token, owner, ratio) VALUES (37, 'legacy', 'primary', 'staging', 37.13);
