-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, ratio, count, region) VALUES ('standard', 96.66, 62, 'green');
INSERT INTO commits_records (owner, ratio, count, region) VALUES ('standard', 59.26, 52, 'latest');
INSERT INTO commits_records (owner, ratio, count, region) VALUES ('local', 73.47, 64, 'primary');
