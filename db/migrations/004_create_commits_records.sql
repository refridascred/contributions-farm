-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    created_at TIMESTAMP,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (score, active, level, region) VALUES (8.06, 42, 91, 'primary');
INSERT INTO commits_records (score, active, level, region) VALUES (15.61, 66, 60, 'strict');
INSERT INTO commits_records (score, active, level, region) VALUES (74.59, 5, 82, 'staging');
