-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (label, region, count, rank) VALUES ('blue', 'fallback', 20, 82);
INSERT INTO commits_records (label, region, count, rank) VALUES ('eu-west', 'legacy', 10, 35);
INSERT INTO commits_records (label, region, count, rank) VALUES ('standard', 'edge', 49, 99);
