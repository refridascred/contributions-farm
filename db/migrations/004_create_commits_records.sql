-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (count, region, rank) VALUES (75, 'standard', 1);
INSERT INTO commits_records (count, region, rank) VALUES (0, 'cached', 18);
INSERT INTO commits_records (count, region, rank) VALUES (69, 'green', 91);
