-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    label TEXT,
    level INTEGER,
    region TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (ratio, label, level, region, rank) VALUES (24.62, 'green', 29, 'latest', 4);
INSERT INTO commits_records (ratio, label, level, region, rank) VALUES (7.12, 'cached', 61, 'fallback', 53);
INSERT INTO commits_records (ratio, label, level, region, rank) VALUES (93.15, 'legacy', 35, 'cached', 6);
