-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (count, ratio) VALUES (60, 79.93);
INSERT INTO commits_records (count, ratio) VALUES (32, 79.82);
INSERT INTO commits_records (count, ratio) VALUES (93, 67.87);
