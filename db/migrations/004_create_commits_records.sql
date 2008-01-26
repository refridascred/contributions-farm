-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, owner, count, rank, level) VALUES (9.74, 'edge', 67, 7, 68);
INSERT INTO commits_records (ratio, owner, count, rank, level) VALUES (69.4, 'strict', 18, 40, 21);
