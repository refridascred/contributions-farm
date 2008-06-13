-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    weight REAL,
    region TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (ratio, owner, weight, region, token) VALUES (26.99, 'fallback', 69.78, 'eu-west', 'strict');
INSERT INTO commits_records (ratio, owner, weight, region, token) VALUES (97.55, 'primary', 94.79, 'green', 'blue');
INSERT INTO commits_records (ratio, owner, weight, region, token) VALUES (71.47, 'local', 60.13, 'latest', 'latest');
