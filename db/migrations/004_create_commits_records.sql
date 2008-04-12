-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (region, score, ratio) VALUES ('strict', 78.33, 98.65);
INSERT INTO commits_records (region, score, ratio) VALUES ('local', 27.05, 70.11);
INSERT INTO commits_records (region, score, ratio) VALUES ('stable', 4.86, 53.16);
