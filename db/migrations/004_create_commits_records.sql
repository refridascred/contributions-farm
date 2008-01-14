-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER,
    level INTEGER,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (label, count, rank, level, region) VALUES ('local', 47, 27, 25, 'primary');
INSERT INTO commits_records (label, count, rank, level, region) VALUES ('fallback', 17, 73, 77, 'blue');
INSERT INTO commits_records (label, count, rank, level, region) VALUES ('edge', 8, 97, 46, 'stable');
