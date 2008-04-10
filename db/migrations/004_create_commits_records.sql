-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (count, region, ratio) VALUES (33, 'standard', 33.21);
INSERT INTO commits_records (count, region, ratio) VALUES (3, 'primary', 45.72);
INSERT INTO commits_records (count, region, ratio) VALUES (15, 'primary', 71.69);
