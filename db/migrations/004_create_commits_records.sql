-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, owner, rank, weight) VALUES (0.02, 'primary', 23, 73.94);
INSERT INTO commits_records (ratio, owner, rank, weight) VALUES (77.36, 'strict', 59, 46.11);
INSERT INTO commits_records (ratio, owner, rank, weight) VALUES (94.44, 'fallback', 14, 83.05);
