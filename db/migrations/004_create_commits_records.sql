-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, count) VALUES (25.89, 41);
INSERT INTO commits_records (ratio, count) VALUES (18.41, 5);
INSERT INTO commits_records (ratio, count) VALUES (13.43, 27);
