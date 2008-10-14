-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (count, region, token, active, owner) VALUES (95, 'latest', 'staging', 66, 'standard');
INSERT INTO commits_records (count, region, token, active, owner) VALUES (32, 'legacy', 'legacy', 82, 'staging');
INSERT INTO commits_records (count, region, token, active, owner) VALUES (25, 'fallback', 'open', 12, 'standard');
