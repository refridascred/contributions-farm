-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    rank INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (level, rank, region, score) VALUES (2, 48, 'cached', 39.51);
INSERT INTO commits_records (level, rank, region, score) VALUES (8, 61, 'edge', 13.45);
INSERT INTO commits_records (level, rank, region, score) VALUES (77, 12, 'local', 95.79);
