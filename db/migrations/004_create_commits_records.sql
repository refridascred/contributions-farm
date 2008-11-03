-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    created_at TIMESTAMP,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (region, weight, rank, score) VALUES ('cached', 9.92, 98, 59.86);
INSERT INTO commits_records (region, weight, rank, score) VALUES ('edge', 59.47, 28, 30.97);
INSERT INTO commits_records (region, weight, rank, score) VALUES ('open', 19.44, 62, 85.18);
