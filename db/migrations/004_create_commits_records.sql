-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    ratio REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, rank, ratio, label) VALUES ('fallback', 14, 61.22, 'standard');
INSERT INTO commits_records (region, rank, ratio, label) VALUES ('staging', 86, 25.85, 'latest');
INSERT INTO commits_records (region, rank, ratio, label) VALUES ('standard', 97, 96.27, 'primary');
