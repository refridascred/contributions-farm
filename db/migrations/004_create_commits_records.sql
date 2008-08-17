-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (rank, owner, count, region) VALUES (75, 'blue', 96, 'standard');
INSERT INTO commits_records (rank, owner, count, region) VALUES (69, 'blue', 9, 'standard');
