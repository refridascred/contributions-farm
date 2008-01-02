-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (label, rank, level, region) VALUES ('cached', 82, 68, 'eu-west');
INSERT INTO commits_records (label, rank, level, region) VALUES ('fallback', 49, 76, 'strict');
INSERT INTO commits_records (label, rank, level, region) VALUES ('edge', 34, 46, 'eu-west');
