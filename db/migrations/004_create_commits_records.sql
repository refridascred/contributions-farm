-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    region TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (owner, count, level, region) VALUES ('fallback', 68, 22, 'standard');
INSERT INTO commits_records (owner, count, level, region) VALUES ('staging', 9, 91, 'latest');
INSERT INTO commits_records (owner, count, level, region) VALUES ('staging', 86, 46, 'latest');
