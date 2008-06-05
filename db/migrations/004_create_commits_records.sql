-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (owner, rank, label, weight) VALUES ('fallback', 25, 'primary', 2.98);
INSERT INTO commits_records (owner, rank, label, weight) VALUES ('latest', 2, 'green', 13.02);
