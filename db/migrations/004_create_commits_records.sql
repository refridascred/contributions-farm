-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (count, owner, ratio, rank) VALUES (58, 'legacy', 70.33, 84);
INSERT INTO commits_records (count, owner, ratio, rank) VALUES (67, 'legacy', 25.99, 90);
INSERT INTO commits_records (count, owner, ratio, rank) VALUES (64, 'stable', 54.82, 61);
