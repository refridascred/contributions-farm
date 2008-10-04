-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (count, active, rank) VALUES (0, 28, 31);
INSERT INTO commits_records (count, active, rank) VALUES (93, 71, 95);
INSERT INTO commits_records (count, active, rank) VALUES (82, 21, 22);
