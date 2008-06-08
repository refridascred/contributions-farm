-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (label, ratio, rank) VALUES ('primary', 25.35, 22);
INSERT INTO commits_records (label, ratio, rank) VALUES ('primary', 52.77, 21);
