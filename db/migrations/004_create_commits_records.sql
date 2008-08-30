-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (rank, ratio, owner) VALUES (73, 36.87, 'staging');
INSERT INTO commits_records (rank, ratio, owner) VALUES (88, 71.68, 'legacy');
INSERT INTO commits_records (rank, ratio, owner) VALUES (3, 6.07, 'latest');
