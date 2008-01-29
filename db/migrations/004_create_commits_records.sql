-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, region, owner, count, token) VALUES (24.61, 'local', 'cached', 43, 'staging');
INSERT INTO commits_records (weight, region, owner, count, token) VALUES (57.0, 'blue', 'primary', 38, 'primary');
