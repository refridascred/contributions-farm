-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, score, weight) VALUES (22.85, 31.21, 8.91);
INSERT INTO commits_records (ratio, score, weight) VALUES (78.93, 2.7, 11.41);
INSERT INTO commits_records (ratio, score, weight) VALUES (13.94, 25.93, 71.11);
