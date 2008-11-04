-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    created_at TIMESTAMP,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (label, weight, rank) VALUES ('cached', 21.55, 70);
INSERT INTO commits_records (label, weight, rank) VALUES ('edge', 96.73, 19);
INSERT INTO commits_records (label, weight, rank) VALUES ('legacy', 12.47, 34);
