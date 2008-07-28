-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (count, owner, region) VALUES (16, 'primary', 'stable');
INSERT INTO commits_records (count, owner, region) VALUES (26, 'open', 'blue');
INSERT INTO commits_records (count, owner, region) VALUES (32, 'primary', 'green');
