-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (region, weight, ratio, score) VALUES ('eu-west', 95.99, 69.92, 43.32);
INSERT INTO commits_records (region, weight, ratio, score) VALUES ('fallback', 19.37, 69.34, 85.24);
