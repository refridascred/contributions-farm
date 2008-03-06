-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (rank, weight, count) VALUES (86, 42.29, 11);
INSERT INTO commits_records (rank, weight, count) VALUES (93, 31.42, 62);
INSERT INTO commits_records (rank, weight, count) VALUES (65, 6.86, 69);
