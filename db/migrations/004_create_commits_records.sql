-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (weight, owner, region, active) VALUES (41.9, 'standard', 'staging', 15);
INSERT INTO commits_records (weight, owner, region, active) VALUES (18.8, 'local', 'green', 94);
INSERT INTO commits_records (weight, owner, region, active) VALUES (29.2, 'open', 'legacy', 52);
