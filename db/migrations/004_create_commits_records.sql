-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, level, weight, ratio) VALUES (59.06, 99, 16.37, 17.58);
INSERT INTO commits_records (score, level, weight, ratio) VALUES (74.08, 6, 97.51, 23.74);
INSERT INTO commits_records (score, level, weight, ratio) VALUES (97.01, 74, 25.07, 74.27);
