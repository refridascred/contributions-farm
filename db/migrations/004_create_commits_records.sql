-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, region, ratio) VALUES (51, 'standard', 35.57);
INSERT INTO commits_records (rank, region, ratio) VALUES (38, 'green', 43.13);
