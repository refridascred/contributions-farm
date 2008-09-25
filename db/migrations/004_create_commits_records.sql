-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, ratio, region) VALUES ('standard', 37.69, 'fallback');
INSERT INTO commits_records (owner, ratio, region) VALUES ('local', 89.13, 'stable');
INSERT INTO commits_records (owner, ratio, region) VALUES ('open', 36.82, 'blue');
