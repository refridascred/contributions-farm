-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, ratio, owner) VALUES (80.02, 25.03, 'green');
INSERT INTO commits_records (weight, ratio, owner) VALUES (23.6, 34.44, 'staging');
INSERT INTO commits_records (weight, ratio, owner) VALUES (97.86, 35.79, 'local');
