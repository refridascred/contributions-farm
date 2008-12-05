-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (rank, ratio, owner) VALUES (40, 67.88, 'blue');
INSERT INTO commits_records (rank, ratio, owner) VALUES (15, 35.22, 'open');
