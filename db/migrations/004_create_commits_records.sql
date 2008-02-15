-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (weight, count, token) VALUES (26.29, 10, 'blue');
INSERT INTO commits_records (weight, count, token) VALUES (11.26, 25, 'cached');
INSERT INTO commits_records (weight, count, token) VALUES (54.08, 46, 'strict');
