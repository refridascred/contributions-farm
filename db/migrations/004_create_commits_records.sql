-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, region, ratio, rank) VALUES (59.65, 'open', 86.0, 8);
INSERT INTO commits_records (score, region, ratio, rank) VALUES (21.24, 'edge', 4.76, 87);
