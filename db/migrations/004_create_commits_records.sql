-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    region TEXT,
    rank INTEGER,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, region, rank, owner, weight) VALUES (74.05, 'legacy', 20, 'primary', 66.95);
INSERT INTO commits_records (ratio, region, rank, owner, weight) VALUES (6.31, 'cached', 74, 'fallback', 50.63);
