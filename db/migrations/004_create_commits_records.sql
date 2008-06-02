-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, owner, count) VALUES (68.79, 'edge', 85);
INSERT INTO commits_records (score, owner, count) VALUES (69.66, 'local', 61);
INSERT INTO commits_records (score, owner, count) VALUES (56.88, 'fallback', 34);
