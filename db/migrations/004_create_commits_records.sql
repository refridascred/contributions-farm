-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (region, count, rank, token, weight) VALUES ('open', 80, 25, 'eu-west', 83.72);
INSERT INTO commits_records (region, count, rank, token, weight) VALUES ('blue', 33, 45, 'latest', 39.11);
