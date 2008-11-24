-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    rank INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, owner, rank, count, level) VALUES ('staging', 'eu-west', 59, 69, 1);
INSERT INTO commits_records (token, owner, rank, count, level) VALUES ('edge', 'eu-west', 40, 31, 43);
