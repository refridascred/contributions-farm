-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, weight, region) VALUES (98, 95.58, 'legacy');
INSERT INTO commits_records (rank, weight, region) VALUES (66, 26.57, 'primary');
INSERT INTO commits_records (rank, weight, region) VALUES (89, 7.8, 'local');
