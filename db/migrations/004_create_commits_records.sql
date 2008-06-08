-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, owner, weight, count, region) VALUES (82, 'eu-west', 95.22, 46, 'green');
INSERT INTO commits_records (rank, owner, weight, count, region) VALUES (12, 'edge', 91.05, 33, 'staging');
INSERT INTO commits_records (rank, owner, weight, count, region) VALUES (32, 'fallback', 57.0, 72, 'blue');
