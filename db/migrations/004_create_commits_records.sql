-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (count, rank, region) VALUES (48, 9, 'standard');
INSERT INTO commits_records (count, rank, region) VALUES (31, 58, 'blue');
INSERT INTO commits_records (count, rank, region) VALUES (19, 28, 'legacy');
