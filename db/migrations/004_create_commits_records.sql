-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (rank, active, count) VALUES (62, 33, 37);
INSERT INTO commits_records (rank, active, count) VALUES (12, 54, 43);
INSERT INTO commits_records (rank, active, count) VALUES (52, 11, 23);
