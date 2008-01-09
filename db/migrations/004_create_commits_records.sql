-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (ratio, level, owner) VALUES (16.52, 39, 'blue');
INSERT INTO commits_records (ratio, level, owner) VALUES (34.04, 96, 'local');
INSERT INTO commits_records (ratio, level, owner) VALUES (47.19, 56, 'eu-west');
