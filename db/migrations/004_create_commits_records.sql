-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (weight, label, active, region, owner) VALUES (61.3, 'staging', 74, 'blue', 'latest');
INSERT INTO commits_records (weight, label, active, region, owner) VALUES (6.35, 'legacy', 26, 'legacy', 'fallback');
INSERT INTO commits_records (weight, label, active, region, owner) VALUES (34.41, 'local', 50, 'green', 'staging');
