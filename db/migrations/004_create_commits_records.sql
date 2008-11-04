-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, rank, ratio) VALUES (63.15, 40, 62.19);
INSERT INTO commits_records (weight, rank, ratio) VALUES (40.77, 43, 89.76);
INSERT INTO commits_records (weight, rank, ratio) VALUES (55.36, 48, 63.0);
