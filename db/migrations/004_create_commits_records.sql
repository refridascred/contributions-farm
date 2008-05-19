-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (count, region, score, label, weight) VALUES (35, 'open', 37.49, 'cached', 93.8);
INSERT INTO commits_records (count, region, score, label, weight) VALUES (70, 'strict', 67.39, 'cached', 9.1);
INSERT INTO commits_records (count, region, score, label, weight) VALUES (88, 'blue', 79.62, 'latest', 2.45);
