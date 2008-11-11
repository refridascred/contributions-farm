-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (score, level, count, region) VALUES (92.57, 62, 30, 'green');
INSERT INTO commits_records (score, level, count, region) VALUES (55.23, 96, 29, 'primary');
INSERT INTO commits_records (score, level, count, region) VALUES (63.83, 62, 7, 'strict');
