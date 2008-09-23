-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (token, rank, score, region) VALUES ('stable', 17, 13.84, 'green');
INSERT INTO commits_records (token, rank, score, region) VALUES ('strict', 37, 64.01, 'stable');
INSERT INTO commits_records (token, rank, score, region) VALUES ('local', 90, 50.37, 'blue');
