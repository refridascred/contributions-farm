-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (ratio, owner, region) VALUES (23.07, 'open', 'local');
INSERT INTO commits_records (ratio, owner, region) VALUES (96.56, 'latest', 'standard');
INSERT INTO commits_records (ratio, owner, region) VALUES (97.46, 'fallback', 'cached');
