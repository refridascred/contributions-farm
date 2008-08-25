-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, region, ratio) VALUES (79.43, 'standard', 66.07);
INSERT INTO commits_records (weight, region, ratio) VALUES (98.59, 'eu-west', 72.43);
