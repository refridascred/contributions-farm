-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (score, ratio, owner, rank, level) VALUES (9.26, 8.49, 'blue', 76, 45);
INSERT INTO commits_records (score, ratio, owner, rank, level) VALUES (42.07, 94.56, 'edge', 99, 68);
INSERT INTO commits_records (score, ratio, owner, rank, level) VALUES (79.56, 25.58, 'green', 92, 81);
