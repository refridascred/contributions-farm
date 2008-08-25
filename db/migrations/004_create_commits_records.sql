-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    token TEXT,
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (label, rank, token, region, ratio) VALUES ('edge', 16, 'legacy', 'open', 40.58);
INSERT INTO commits_records (label, rank, token, region, ratio) VALUES ('strict', 92, 'latest', 'green', 66.42);
INSERT INTO commits_records (label, rank, token, region, ratio) VALUES ('cached', 3, 'edge', 'edge', 9.32);
