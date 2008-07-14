-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (level, rank, count) VALUES (88, 86, 38);
INSERT INTO commits_records (level, rank, count) VALUES (45, 64, 9);
INSERT INTO commits_records (level, rank, count) VALUES (27, 79, 3);
