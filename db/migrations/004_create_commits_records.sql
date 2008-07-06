-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (label, region, level, count, token) VALUES ('staging', 'latest', 24, 8, 'stable');
INSERT INTO commits_records (label, region, level, count, token) VALUES ('latest', 'local', 99, 15, 'edge');
