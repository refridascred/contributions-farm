-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (active, owner, region) VALUES (10, 'legacy', 'latest');
INSERT INTO commits_records (active, owner, region) VALUES (50, 'local', 'stable');
INSERT INTO commits_records (active, owner, region) VALUES (58, 'primary', 'fallback');
