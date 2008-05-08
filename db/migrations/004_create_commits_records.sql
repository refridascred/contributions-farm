-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (owner, ratio, region) VALUES ('legacy', 51.52, 'eu-west');
INSERT INTO commits_records (owner, ratio, region) VALUES ('primary', 7.74, 'latest');
INSERT INTO commits_records (owner, ratio, region) VALUES ('latest', 16.77, 'fallback');
