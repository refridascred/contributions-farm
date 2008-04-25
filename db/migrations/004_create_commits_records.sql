-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (ratio, token, rank) VALUES (98.76, 'cached', 1);
INSERT INTO commits_records (ratio, token, rank) VALUES (31.22, 'strict', 38);
INSERT INTO commits_records (ratio, token, rank) VALUES (72.2, 'fallback', 11);
