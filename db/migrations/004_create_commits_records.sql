-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, rank, active, count) VALUES ('cached', 72, 72, 91);
INSERT INTO commits_records (owner, rank, active, count) VALUES ('stable', 98, 72, 66);
INSERT INTO commits_records (owner, rank, active, count) VALUES ('blue', 23, 14, 43);
