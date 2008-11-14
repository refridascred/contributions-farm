-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, weight, score) VALUES (80, 1.59, 38.83);
INSERT INTO commits_records (count, weight, score) VALUES (78, 82.49, 78.38);
INSERT INTO commits_records (count, weight, score) VALUES (71, 38.74, 29.48);
