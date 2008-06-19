-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (region, level, ratio, score) VALUES ('legacy', 79, 49.23, 91.67);
INSERT INTO commits_records (region, level, ratio, score) VALUES ('standard', 25, 67.13, 96.83);
INSERT INTO commits_records (region, level, ratio, score) VALUES ('blue', 75, 52.57, 59.66);
