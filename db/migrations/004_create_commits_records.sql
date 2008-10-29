-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    weight REAL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, ratio, weight, rank) VALUES ('blue', 46.89, 2.97, 81);
INSERT INTO commits_records (region, ratio, weight, rank) VALUES ('latest', 16.18, 42.08, 57);
