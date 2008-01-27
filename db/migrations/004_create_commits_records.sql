-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (token, rank, ratio) VALUES ('stable', 69, 71.24);
INSERT INTO commits_records (token, rank, ratio) VALUES ('latest', 89, 23.01);
INSERT INTO commits_records (token, rank, ratio) VALUES ('open', 57, 30.54);
