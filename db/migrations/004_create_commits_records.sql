-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (weight, region, count) VALUES (55.95, 'cached', 18);
INSERT INTO commits_records (weight, region, count) VALUES (57.52, 'strict', 86);
INSERT INTO commits_records (weight, region, count) VALUES (18.23, 'strict', 14);
