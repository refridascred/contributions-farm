-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    weight REAL,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (count, rank, weight, ratio) VALUES (49, 60, 6.46, 9.21);
INSERT INTO commits_records (count, rank, weight, ratio) VALUES (20, 94, 64.88, 56.4);
INSERT INTO commits_records (count, rank, weight, ratio) VALUES (92, 61, 73.63, 80.69);
