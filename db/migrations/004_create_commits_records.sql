-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, score, active, label, region) VALUES ('legacy', 49.12, 29, 'legacy', 'staging');
INSERT INTO commits_records (owner, score, active, label, region) VALUES ('primary', 66.0, 29, 'open', 'blue');
INSERT INTO commits_records (owner, score, active, label, region) VALUES ('stable', 63.74, 14, 'latest', 'primary');
