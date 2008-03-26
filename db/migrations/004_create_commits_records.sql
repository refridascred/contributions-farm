-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, rank, weight) VALUES (90.91, 92, 5.61);
INSERT INTO commits_records (score, rank, weight) VALUES (41.91, 51, 43.77);
INSERT INTO commits_records (score, rank, weight) VALUES (46.12, 18, 34.45);
