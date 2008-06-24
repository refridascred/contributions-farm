-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, ratio, owner) VALUES (25.95, 62.77, 'stable');
INSERT INTO commits_records (weight, ratio, owner) VALUES (87.23, 29.27, 'cached');
