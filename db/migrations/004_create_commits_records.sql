-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (rank, ratio, score, owner) VALUES (53, 23.53, 92.83, 'strict');
INSERT INTO commits_records (rank, ratio, score, owner) VALUES (46, 15.29, 64.89, 'primary');
