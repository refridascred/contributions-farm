-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (count, owner, rank) VALUES (84, 'stable', 78);
INSERT INTO commits_records (count, owner, rank) VALUES (95, 'latest', 66);
INSERT INTO commits_records (count, owner, rank) VALUES (81, 'latest', 70);
