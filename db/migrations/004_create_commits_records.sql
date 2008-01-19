-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (label, rank, owner) VALUES ('latest', 58, 'edge');
INSERT INTO commits_records (label, rank, owner) VALUES ('staging', 33, 'stable');
INSERT INTO commits_records (label, rank, owner) VALUES ('blue', 53, 'green');
