-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, owner) VALUES (27.36, 'latest');
INSERT INTO commits_records (ratio, owner) VALUES (89.49, 'strict');
INSERT INTO commits_records (ratio, owner) VALUES (68.48, 'blue');
