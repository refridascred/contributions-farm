-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (active, owner, score, region) VALUES (34, 'eu-west', 98.0, 'latest');
INSERT INTO commits_records (active, owner, score, region) VALUES (39, 'eu-west', 62.04, 'standard');
INSERT INTO commits_records (active, owner, score, region) VALUES (64, 'edge', 50.82, 'fallback');
