-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (rank, token, weight, owner, region) VALUES (17, 'local', 58.05, 'eu-west', 'primary');
INSERT INTO commits_records (rank, token, weight, owner, region) VALUES (35, 'primary', 89.26, 'edge', 'fallback');
INSERT INTO commits_records (rank, token, weight, owner, region) VALUES (90, 'edge', 8.67, 'cached', 'cached');
