-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    ratio REAL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (count, ratio, token, rank) VALUES (45, 38.7, 'blue', 41);
INSERT INTO commits_records (count, ratio, token, rank) VALUES (51, 22.91, 'strict', 74);
INSERT INTO commits_records (count, ratio, token, rank) VALUES (17, 37.11, 'blue', 90);
