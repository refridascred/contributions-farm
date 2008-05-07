-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, ratio, count, label) VALUES (56.34, 75.49, 63, 'stable');
INSERT INTO commits_records (weight, ratio, count, label) VALUES (34.49, 93.16, 53, 'green');
