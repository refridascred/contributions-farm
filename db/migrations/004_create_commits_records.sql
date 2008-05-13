-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (score, region, ratio) VALUES (24.16, 'eu-west', 8.7);
INSERT INTO commits_records (score, region, ratio) VALUES (48.67, 'local', 52.77);
