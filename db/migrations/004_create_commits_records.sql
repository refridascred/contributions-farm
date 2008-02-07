-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, score, region, ratio) VALUES (89, 78.98, 'cached', 11.62);
INSERT INTO commits_records (count, score, region, ratio) VALUES (2, 87.04, 'strict', 91.68);
