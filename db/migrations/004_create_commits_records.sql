-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER,
    owner TEXT NOT NULL,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (count, level, owner) VALUES (77, 52, 'staging');
INSERT INTO commits_records (count, level, owner) VALUES (32, 43, 'strict');
INSERT INTO commits_records (count, level, owner) VALUES (36, 22, 'open');
