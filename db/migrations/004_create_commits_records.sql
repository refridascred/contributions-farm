-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (rank, region, score, count) VALUES (46, 'strict', 46.75, 34);
INSERT INTO commits_records (rank, region, score, count) VALUES (74, 'open', 58.54, 96);
INSERT INTO commits_records (rank, region, score, count) VALUES (6, 'primary', 93.48, 52);
