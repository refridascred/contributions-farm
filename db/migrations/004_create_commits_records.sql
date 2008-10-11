-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (count, weight, region) VALUES (74, 50.06, 'fallback');
INSERT INTO commits_records (count, weight, region) VALUES (4, 48.41, 'primary');
INSERT INTO commits_records (count, weight, region) VALUES (5, 36.46, 'stable');
