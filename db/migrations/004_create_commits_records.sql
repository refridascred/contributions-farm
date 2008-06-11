-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, rank, count) VALUES (48.18, 50, 24);
INSERT INTO commits_records (weight, rank, count) VALUES (11.68, 23, 12);
INSERT INTO commits_records (weight, rank, count) VALUES (46.25, 59, 66);
