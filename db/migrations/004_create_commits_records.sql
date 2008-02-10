-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (region, count, rank, token) VALUES ('blue', 88, 50, 'latest');
INSERT INTO commits_records (region, count, rank, token) VALUES ('eu-west', 59, 70, 'cached');
