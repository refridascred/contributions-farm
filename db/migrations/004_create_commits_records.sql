-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (active, rank, owner) VALUES (29, 91, 'legacy');
INSERT INTO commits_records (active, rank, owner) VALUES (54, 63, 'primary');
INSERT INTO commits_records (active, rank, owner) VALUES (38, 2, 'blue');
