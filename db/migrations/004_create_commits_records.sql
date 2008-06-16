-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_score ON commits_records (score);

INSERT INTO commits_records (score, weight, label) VALUES (83.61, 46.76, 'latest');
INSERT INTO commits_records (score, weight, label) VALUES (73.23, 13.19, 'primary');
INSERT INTO commits_records (score, weight, label) VALUES (15.6, 79.29, 'edge');
