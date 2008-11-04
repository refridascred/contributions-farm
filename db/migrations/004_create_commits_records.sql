-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (region, score, rank, count) VALUES ('local', 72.98, 72, 93);
INSERT INTO commits_records (region, score, rank, count) VALUES ('blue', 35.99, 10, 31);
INSERT INTO commits_records (region, score, rank, count) VALUES ('cached', 97.48, 58, 61);
