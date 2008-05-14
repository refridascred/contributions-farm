-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    created_at TIMESTAMP,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, score, ratio, count) VALUES ('strict', 61.86, 47.83, 44);
INSERT INTO commits_records (region, score, ratio, count) VALUES ('strict', 41.02, 72.0, 87);
INSERT INTO commits_records (region, score, ratio, count) VALUES ('local', 59.56, 16.8, 38);
