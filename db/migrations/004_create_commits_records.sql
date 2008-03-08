-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (region, token, owner) VALUES ('legacy', 'local', 'blue');
INSERT INTO commits_records (region, token, owner) VALUES ('latest', 'edge', 'primary');
