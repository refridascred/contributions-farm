-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    region TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (level, region, rank, weight) VALUES (59, 'cached', 68, 95.2);
INSERT INTO commits_records (level, region, rank, weight) VALUES (83, 'legacy', 12, 88.5);
