-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, token, weight, count) VALUES (66, 'strict', 13.75, 86);
INSERT INTO commits_records (rank, token, weight, count) VALUES (49, 'stable', 39.83, 39);
INSERT INTO commits_records (rank, token, weight, count) VALUES (15, 'latest', 5.19, 74);
