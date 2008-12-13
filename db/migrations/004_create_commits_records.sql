-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT,
    weight REAL,
    ratio REAL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (count, token, weight, ratio) VALUES (62, 'latest', 30.85, 64.16);
INSERT INTO commits_records (count, token, weight, ratio) VALUES (8, 'local', 57.82, 82.01);
