-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (rank, count, region, weight, token) VALUES (70, 54, 'green', 63.89, 'latest');
INSERT INTO commits_records (rank, count, region, weight, token) VALUES (89, 22, 'blue', 96.72, 'blue');
