-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (weight, region, count) VALUES (97.97, 'staging', 82);
INSERT INTO commits_records (weight, region, count) VALUES (19.64, 'eu-west', 24);
