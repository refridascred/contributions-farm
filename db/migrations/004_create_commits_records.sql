-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, score, weight, ratio) VALUES (20, 35.73, 52.27, 34.08);
INSERT INTO commits_records (count, score, weight, ratio) VALUES (16, 93.99, 88.95, 52.01);
INSERT INTO commits_records (count, score, weight, ratio) VALUES (5, 38.69, 76.64, 11.62);
