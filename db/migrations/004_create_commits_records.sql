-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (count, weight, owner, token, rank) VALUES (51, 14.2, 'local', 'stable', 76);
INSERT INTO commits_records (count, weight, owner, token, rank) VALUES (96, 72.23, 'legacy', 'primary', 57);
