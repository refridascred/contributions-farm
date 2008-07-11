-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (weight, owner, region, label) VALUES (45.86, 'standard', 'eu-west', 'staging');
INSERT INTO commits_records (weight, owner, region, label) VALUES (5.76, 'edge', 'fallback', 'green');
INSERT INTO commits_records (weight, owner, region, label) VALUES (97.13, 'primary', 'green', 'local');
