-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (score, weight) VALUES (51.46, 17.62);
INSERT INTO commits_records (score, weight) VALUES (40.6, 3.88);
INSERT INTO commits_records (score, weight) VALUES (60.91, 20.98);
