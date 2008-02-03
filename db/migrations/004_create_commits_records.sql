-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (label, weight, score) VALUES ('strict', 57.97, 16.21);
INSERT INTO commits_records (label, weight, score) VALUES ('latest', 56.46, 39.15);
INSERT INTO commits_records (label, weight, score) VALUES ('stable', 23.19, 69.1);
