-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    ratio REAL,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (rank, ratio, region, score, weight) VALUES (14, 37.42, 'primary', 35.38, 12.15);
INSERT INTO commits_records (rank, ratio, region, score, weight) VALUES (46, 66.11, 'open', 90.18, 17.66);
