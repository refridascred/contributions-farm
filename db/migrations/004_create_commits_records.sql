-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (owner, ratio, region) VALUES ('green', 72.61, 'cached');
INSERT INTO commits_records (owner, ratio, region) VALUES ('strict', 66.19, 'local');
