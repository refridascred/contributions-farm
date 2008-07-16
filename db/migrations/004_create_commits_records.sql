-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (rank, score, ratio) VALUES (9, 93.41, 34.92);
INSERT INTO commits_records (rank, score, ratio) VALUES (62, 84.36, 0.38);
INSERT INTO commits_records (rank, score, ratio) VALUES (21, 81.32, 87.66);
