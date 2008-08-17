-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, label) VALUES (26.34, 'open');
INSERT INTO commits_records (weight, label) VALUES (72.16, 'staging');
INSERT INTO commits_records (weight, label) VALUES (82.66, 'blue');
