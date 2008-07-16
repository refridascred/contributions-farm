-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    owner TEXT NOT NULL,
    created_at TIMESTAMP,
    region TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (label, owner, region, score) VALUES ('legacy', 'latest', 'eu-west', 23.51);
INSERT INTO commits_records (label, owner, region, score) VALUES ('primary', 'green', 'edge', 56.41);
INSERT INTO commits_records (label, owner, region, score) VALUES ('latest', 'staging', 'strict', 82.45);
