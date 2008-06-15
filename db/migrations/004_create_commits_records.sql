-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (region, rank, score, count, label) VALUES ('latest', 6, 64.07, 20, 'staging');
INSERT INTO commits_records (region, rank, score, count, label) VALUES ('open', 52, 62.71, 44, 'legacy');
INSERT INTO commits_records (region, rank, score, count, label) VALUES ('blue', 48, 35.14, 80, 'legacy');
