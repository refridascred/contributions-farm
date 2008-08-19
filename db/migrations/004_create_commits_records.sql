-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, ratio, level, score) VALUES (41.23, 9.21, 80, 9.71);
INSERT INTO commits_records (weight, ratio, level, score) VALUES (42.79, 46.2, 82, 55.34);
INSERT INTO commits_records (weight, ratio, level, score) VALUES (83.58, 7.04, 2, 82.17);
