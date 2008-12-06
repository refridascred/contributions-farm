-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_rank ON commits_records (rank);

INSERT INTO commits_records (region, score, rank, ratio) VALUES ('staging', 44.64, 89, 35.17);
INSERT INTO commits_records (region, score, rank, ratio) VALUES ('latest', 66.44, 57, 11.75);
INSERT INTO commits_records (region, score, rank, ratio) VALUES ('local', 78.85, 36, 25.9);
