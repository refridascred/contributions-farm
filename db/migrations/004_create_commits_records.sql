-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (label, rank, region, count) VALUES ('local', 88, 'open', 26);
INSERT INTO commits_records (label, rank, region, count) VALUES ('staging', 84, 'strict', 31);
INSERT INTO commits_records (label, rank, region, count) VALUES ('open', 25, 'staging', 2);
