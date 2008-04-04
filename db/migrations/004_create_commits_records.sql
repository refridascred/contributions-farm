-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (weight, region, label) VALUES (52.03, 'legacy', 'staging');
INSERT INTO commits_records (weight, region, label) VALUES (63.35, 'eu-west', 'staging');
INSERT INTO commits_records (weight, region, label) VALUES (37.85, 'standard', 'green');
