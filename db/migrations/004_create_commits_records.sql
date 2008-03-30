-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (active, ratio, rank) VALUES (98, 67.31, 60);
INSERT INTO commits_records (active, ratio, rank) VALUES (4, 19.36, 39);
INSERT INTO commits_records (active, ratio, rank) VALUES (61, 82.5, 69);
