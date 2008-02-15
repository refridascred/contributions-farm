-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (rank, count, ratio, owner) VALUES (81, 31, 46.4, 'primary');
INSERT INTO commits_records (rank, count, ratio, owner) VALUES (9, 90, 64.43, 'cached');
INSERT INTO commits_records (rank, count, ratio, owner) VALUES (0, 0, 74.5, 'strict');
