-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, owner) VALUES (95.96, 'cached');
INSERT INTO commits_records (ratio, owner) VALUES (57.73, 'eu-west');
INSERT INTO commits_records (ratio, owner) VALUES (59.29, 'eu-west');
