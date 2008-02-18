-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (ratio, count, rank) VALUES (81.6, 7, 55);
INSERT INTO commits_records (ratio, count, rank) VALUES (67.14, 27, 65);
INSERT INTO commits_records (ratio, count, rank) VALUES (36.65, 43, 81);
