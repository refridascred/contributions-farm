-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, score, rank, weight) VALUES (17.76, 94.65, 12, 18.9);
INSERT INTO commits_records (ratio, score, rank, weight) VALUES (77.92, 88.43, 81, 22.38);
