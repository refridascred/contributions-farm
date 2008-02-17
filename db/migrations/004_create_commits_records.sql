-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (label, count, rank, weight, token) VALUES ('green', 49, 47, 40.03, 'blue');
INSERT INTO commits_records (label, count, rank, weight, token) VALUES ('local', 21, 60, 29.04, 'open');
