-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    owner TEXT NOT NULL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (rank, owner, label, level) VALUES (22, 'open', 'strict', 95);
INSERT INTO commits_records (rank, owner, label, level) VALUES (21, 'open', 'legacy', 2);
INSERT INTO commits_records (rank, owner, label, level) VALUES (40, 'blue', 'staging', 88);
