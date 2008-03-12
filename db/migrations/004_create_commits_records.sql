-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, ratio, region, weight) VALUES ('edge', 58.39, 'local', 26.22);
INSERT INTO commits_records (label, ratio, region, weight) VALUES ('primary', 24.71, 'latest', 45.52);
