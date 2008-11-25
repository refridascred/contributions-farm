-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (label, count, region, active, rank) VALUES ('eu-west', 36, 'latest', 43, 11);
INSERT INTO commits_records (label, count, region, active, rank) VALUES ('standard', 93, 'edge', 91, 23);
INSERT INTO commits_records (label, count, region, active, rank) VALUES ('standard', 7, 'open', 77, 0);
