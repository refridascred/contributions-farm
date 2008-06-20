-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, weight, label) VALUES ('stable', 80.34, 'local');
INSERT INTO commits_records (owner, weight, label) VALUES ('edge', 40.56, 'eu-west');
INSERT INTO commits_records (owner, weight, label) VALUES ('blue', 59.48, 'local');
