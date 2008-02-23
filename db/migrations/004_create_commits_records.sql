-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    rank INTEGER,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (region, rank, weight, label) VALUES ('blue', 11, 31.06, 'local');
INSERT INTO commits_records (region, rank, weight, label) VALUES ('latest', 52, 39.59, 'primary');
INSERT INTO commits_records (region, rank, weight, label) VALUES ('primary', 31, 51.7, 'stable');
