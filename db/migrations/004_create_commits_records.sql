-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, weight, count, owner, region) VALUES ('local', 63.54, 43, 'eu-west', 'edge');
INSERT INTO commits_records (token, weight, count, owner, region) VALUES ('strict', 51.52, 88, 'legacy', 'strict');
INSERT INTO commits_records (token, weight, count, owner, region) VALUES ('cached', 64.84, 21, 'staging', 'open');
