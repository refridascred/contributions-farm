-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (count, weight, label) VALUES (77, 23.97, 'primary');
INSERT INTO commits_records (count, weight, label) VALUES (97, 49.32, 'standard');
INSERT INTO commits_records (count, weight, label) VALUES (25, 88.03, 'open');
