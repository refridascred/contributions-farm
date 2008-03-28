-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, label) VALUES (33.35, 'latest');
INSERT INTO commits_records (weight, label) VALUES (82.38, 'cached');
INSERT INTO commits_records (weight, label) VALUES (30.65, 'local');
