-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, weight, count, owner, label) VALUES (73, 17.95, 37, 'staging', 'local');
INSERT INTO commits_records (rank, weight, count, owner, label) VALUES (34, 91.52, 31, 'local', 'eu-west');
