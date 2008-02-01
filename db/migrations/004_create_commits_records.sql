-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, weight, owner, region) VALUES (96.1, 13.46, 'open', 'staging');
INSERT INTO commits_records (ratio, weight, owner, region) VALUES (47.52, 12.58, 'local', 'primary');
