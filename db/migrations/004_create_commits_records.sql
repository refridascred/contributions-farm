-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (rank, score, weight) VALUES (53, 63.93, 65.33);
INSERT INTO commits_records (rank, score, weight) VALUES (37, 85.85, 10.52);
INSERT INTO commits_records (rank, score, weight) VALUES (66, 0.13, 29.44);
