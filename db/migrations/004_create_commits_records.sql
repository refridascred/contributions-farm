-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, region, rank) VALUES ('edge', 'open', 21);
INSERT INTO commits_records (owner, region, rank) VALUES ('primary', 'primary', 78);
INSERT INTO commits_records (owner, region, rank) VALUES ('latest', 'cached', 1);
