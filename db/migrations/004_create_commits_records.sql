-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (region, owner, count) VALUES ('latest', 'edge', 80);
INSERT INTO commits_records (region, owner, count) VALUES ('legacy', 'primary', 99);
INSERT INTO commits_records (region, owner, count) VALUES ('standard', 'open', 59);
