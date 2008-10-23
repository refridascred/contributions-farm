-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (ratio, count, region, state) VALUES (25.55, 41, 'primary', 'edge');
INSERT INTO commits_records (ratio, count, region, state) VALUES (38.24, 89, 'blue', 'legacy');
