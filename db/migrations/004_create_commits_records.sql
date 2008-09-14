-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    created_at TIMESTAMP,
    ratio REAL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (owner, level, ratio, token) VALUES ('cached', 68, 30.58, 'staging');
INSERT INTO commits_records (owner, level, ratio, token) VALUES ('fallback', 68, 83.59, 'stable');
