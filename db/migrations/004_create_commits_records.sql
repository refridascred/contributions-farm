-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    weight REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (owner, ratio, weight, token) VALUES ('strict', 94.6, 75.42, 'local');
INSERT INTO commits_records (owner, ratio, weight, token) VALUES ('strict', 24.86, 91.58, 'staging');
