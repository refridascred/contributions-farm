-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, count, weight, level) VALUES (18, 37, 88.81, 27);
INSERT INTO commits_records (rank, count, weight, level) VALUES (47, 55, 32.55, 44);
INSERT INTO commits_records (rank, count, weight, level) VALUES (25, 47, 25.6, 85);
