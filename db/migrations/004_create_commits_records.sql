-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (rank, count, label, score, owner) VALUES (24, 6, 'edge', 6.31, 'stable');
INSERT INTO commits_records (rank, count, label, score, owner) VALUES (56, 46, 'strict', 67.82, 'blue');
INSERT INTO commits_records (rank, count, label, score, owner) VALUES (22, 90, 'standard', 86.07, 'strict');
