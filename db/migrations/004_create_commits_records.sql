-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (label, rank) VALUES ('staging', 16);
INSERT INTO commits_records (label, rank) VALUES ('open', 75);
INSERT INTO commits_records (label, rank) VALUES ('green', 2);
