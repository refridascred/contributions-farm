-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (rank, score, weight, ratio) VALUES (87, 48.4, 50.32, 16.37);
INSERT INTO commits_records (rank, score, weight, ratio) VALUES (41, 66.62, 23.92, 52.86);
INSERT INTO commits_records (rank, score, weight, ratio) VALUES (67, 97.74, 4.0, 47.29);
