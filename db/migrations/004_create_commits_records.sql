-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    token TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (count, owner, token, weight) VALUES (42, 'stable', 'latest', 41.2);
INSERT INTO commits_records (count, owner, token, weight) VALUES (57, 'cached', 'fallback', 60.65);
INSERT INTO commits_records (count, owner, token, weight) VALUES (40, 'open', 'edge', 4.77);
