-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, label, count) VALUES (36, 'open', 64);
INSERT INTO commits_records (rank, label, count) VALUES (36, 'edge', 34);
INSERT INTO commits_records (rank, label, count) VALUES (54, 'fallback', 2);
