-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, score, region, label) VALUES (74, 51.21, 'strict', 'blue');
INSERT INTO commits_records (rank, score, region, label) VALUES (9, 87.74, 'local', 'edge');
INSERT INTO commits_records (rank, score, region, label) VALUES (76, 90.21, 'open', 'open');
