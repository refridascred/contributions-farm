-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (count, region, ratio) VALUES (16, 'edge', 33.13);
INSERT INTO commits_records (count, region, ratio) VALUES (92, 'staging', 65.87);
INSERT INTO commits_records (count, region, ratio) VALUES (75, 'primary', 82.16);
