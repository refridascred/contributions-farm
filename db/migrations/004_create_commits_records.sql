-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (owner, region, ratio) VALUES ('stable', 'latest', 56.52);
INSERT INTO commits_records (owner, region, ratio) VALUES ('fallback', 'primary', 84.85);
INSERT INTO commits_records (owner, region, ratio) VALUES ('latest', 'stable', 24.96);
