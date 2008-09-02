-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    region TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, level, region, score) VALUES (10.09, 21, 'latest', 83.33);
INSERT INTO commits_records (ratio, level, region, score) VALUES (40.38, 1, 'blue', 34.68);
INSERT INTO commits_records (ratio, level, region, score) VALUES (85.68, 28, 'local', 9.68);
