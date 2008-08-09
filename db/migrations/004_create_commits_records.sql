-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (owner, level, region, ratio) VALUES ('open', 35, 'staging', 82.5);
INSERT INTO commits_records (owner, level, region, ratio) VALUES ('blue', 56, 'open', 77.9);
