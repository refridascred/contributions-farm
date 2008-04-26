-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (label, rank) VALUES ('fallback', 22);
INSERT INTO commits_records (label, rank) VALUES ('green', 98);
INSERT INTO commits_records (label, rank) VALUES ('staging', 62);
