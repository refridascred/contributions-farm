-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    ratio REAL,
    region TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, ratio, region, active) VALUES ('open', 96.46, 'strict', 39);
INSERT INTO commits_records (owner, ratio, region, active) VALUES ('latest', 9.79, 'latest', 83);
