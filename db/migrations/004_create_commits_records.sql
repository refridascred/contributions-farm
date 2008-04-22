-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    rank INTEGER,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (ratio, rank, region, count) VALUES (54.48, 97, 'staging', 89);
INSERT INTO commits_records (ratio, rank, region, count) VALUES (84.37, 3, 'eu-west', 63);
INSERT INTO commits_records (ratio, rank, region, count) VALUES (61.56, 28, 'eu-west', 8);
