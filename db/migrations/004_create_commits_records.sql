-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (region, rank, token) VALUES ('standard', 2, 'cached');
INSERT INTO commits_records (region, rank, token) VALUES ('open', 58, 'strict');
INSERT INTO commits_records (region, rank, token) VALUES ('staging', 80, 'legacy');
