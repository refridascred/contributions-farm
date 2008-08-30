-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    rank INTEGER,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (token, rank, region, score) VALUES ('strict', 6, 'open', 10.98);
INSERT INTO commits_records (token, rank, region, score) VALUES ('primary', 62, 'open', 30.52);
