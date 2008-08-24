-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    token TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_token ON commits_records (token);

INSERT INTO commits_records (owner, ratio, token, count) VALUES ('local', 94.5, 'local', 43);
INSERT INTO commits_records (owner, ratio, token, count) VALUES ('staging', 14.36, 'primary', 84);
