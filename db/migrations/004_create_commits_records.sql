-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, score, weight, owner) VALUES (32.79, 69.47, 14.17, 'green');
INSERT INTO commits_records (ratio, score, weight, owner) VALUES (5.62, 71.25, 76.36, 'legacy');
