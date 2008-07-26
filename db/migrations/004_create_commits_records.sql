-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, score, level) VALUES (97.58, 87.13, 66);
INSERT INTO commits_records (weight, score, level) VALUES (9.31, 81.71, 57);
INSERT INTO commits_records (weight, score, level) VALUES (42.16, 67.84, 39);
