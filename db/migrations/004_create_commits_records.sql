-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, score, weight) VALUES (81, 61.51, 20.69);
INSERT INTO commits_records (count, score, weight) VALUES (44, 54.3, 56.03);
INSERT INTO commits_records (count, score, weight) VALUES (51, 7.46, 71.01);
