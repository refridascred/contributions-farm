-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, count, token, active, region) VALUES ('cached', 18, 'latest', 62, 'blue');
INSERT INTO commits_records (owner, count, token, active, region) VALUES ('primary', 78, 'standard', 43, 'staging');
INSERT INTO commits_records (owner, count, token, active, region) VALUES ('edge', 10, 'legacy', 32, 'standard');
