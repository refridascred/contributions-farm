-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    rank INTEGER,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (rank, region, weight) VALUES (66, 'primary', 13.03);
INSERT INTO commits_records (rank, region, weight) VALUES (52, 'staging', 47.0);
INSERT INTO commits_records (rank, region, weight) VALUES (93, 'cached', 4.39);
