-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, ratio, owner, region) VALUES (43.67, 28.63, 'standard', 'strict');
INSERT INTO commits_records (weight, ratio, owner, region) VALUES (11.06, 43.03, 'cached', 'strict');
