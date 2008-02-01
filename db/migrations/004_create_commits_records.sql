-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (token, score, weight) VALUES ('edge', 80.76, 46.31);
INSERT INTO commits_records (token, score, weight) VALUES ('latest', 20.14, 60.6);
