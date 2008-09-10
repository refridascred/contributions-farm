-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, owner, region, rank) VALUES (72.84, 'primary', 'cached', 19);
INSERT INTO commits_records (ratio, owner, region, rank) VALUES (25.93, 'legacy', 'open', 19);
