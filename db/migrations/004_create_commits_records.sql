-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (rank, label, ratio, count, score) VALUES (91, 'stable', 66.24, 28, 14.67);
INSERT INTO commits_records (rank, label, ratio, count, score) VALUES (50, 'green', 22.55, 43, 21.77);
INSERT INTO commits_records (rank, label, ratio, count, score) VALUES (75, 'edge', 88.89, 37, 81.0);
