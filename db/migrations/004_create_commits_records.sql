-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, ratio, count, region, rank) VALUES ('edge', 38.38, 85, 'fallback', 83);
INSERT INTO commits_records (label, ratio, count, region, rank) VALUES ('blue', 94.56, 38, 'standard', 13);
INSERT INTO commits_records (label, ratio, count, region, rank) VALUES ('open', 82.74, 23, 'open', 90);
