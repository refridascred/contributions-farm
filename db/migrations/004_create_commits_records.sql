-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, owner, label) VALUES (63.35, 'latest', 'fallback');
INSERT INTO commits_records (ratio, owner, label) VALUES (2.1, 'open', 'latest');
INSERT INTO commits_records (ratio, owner, label) VALUES (43.26, 'fallback', 'green');
