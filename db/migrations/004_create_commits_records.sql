-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, owner, count, label) VALUES (63.04, 'open', 97, 'legacy');
INSERT INTO commits_records (weight, owner, count, label) VALUES (32.53, 'latest', 17, 'stable');
