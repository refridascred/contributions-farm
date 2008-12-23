-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    owner TEXT NOT NULL,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, owner, token) VALUES ('open', 'staging', 'stable');
INSERT INTO commits_records (region, owner, token) VALUES ('primary', 'primary', 'strict');
INSERT INTO commits_records (region, owner, token) VALUES ('local', 'open', 'fallback');
