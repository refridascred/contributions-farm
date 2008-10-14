-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    weight REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (score, ratio, weight, level) VALUES (66.39, 83.09, 38.74, 24);
INSERT INTO commits_records (score, ratio, weight, level) VALUES (42.24, 46.83, 79.76, 83);
INSERT INTO commits_records (score, ratio, weight, level) VALUES (51.88, 76.09, 44.14, 70);
