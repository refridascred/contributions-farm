-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    owner TEXT NOT NULL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (weight, rank, owner, token, score) VALUES (79.62, 66, 'latest', 'staging', 67.94);
INSERT INTO commits_records (weight, rank, owner, token, score) VALUES (70.62, 15, 'staging', 'latest', 65.96);
INSERT INTO commits_records (weight, rank, owner, token, score) VALUES (72.62, 1, 'primary', 'green', 39.61);
