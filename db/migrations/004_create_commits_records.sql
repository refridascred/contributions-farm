-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    created_at TIMESTAMP,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, ratio, weight, label) VALUES (22.76, 16.74, 50.54, 'eu-west');
INSERT INTO commits_records (score, ratio, weight, label) VALUES (97.51, 51.76, 3.48, 'open');
INSERT INTO commits_records (score, ratio, weight, label) VALUES (35.27, 73.83, 75.6, 'blue');
