-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (region, ratio, rank) VALUES ('eu-west', 92.2, 60);
INSERT INTO commits_records (region, ratio, rank) VALUES ('open', 31.74, 96);
INSERT INTO commits_records (region, ratio, rank) VALUES ('green', 92.32, 85);
