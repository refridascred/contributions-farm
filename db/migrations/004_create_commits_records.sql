-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, label, region) VALUES (13.98, 'open', 'blue');
INSERT INTO commits_records (weight, label, region) VALUES (41.39, 'blue', 'primary');
INSERT INTO commits_records (weight, label, region) VALUES (93.5, 'green', 'primary');
