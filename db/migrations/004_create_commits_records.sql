-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    label TEXT,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (token, label, rank, count, score) VALUES ('primary', 'edge', 99, 91, 12.3);
INSERT INTO commits_records (token, label, rank, count, score) VALUES ('blue', 'edge', 34, 60, 27.56);
