-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    weight REAL,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (ratio, weight, region, owner) VALUES (95.21, 10.88, 'eu-west', 'edge');
INSERT INTO commits_records (ratio, weight, region, owner) VALUES (26.98, 12.26, 'green', 'standard');
