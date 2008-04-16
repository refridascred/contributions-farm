-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, token, owner) VALUES (76.55, 'fallback', 'latest');
INSERT INTO commits_records (ratio, token, owner) VALUES (43.25, 'latest', 'stable');
