-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    owner TEXT NOT NULL,
    rank INTEGER,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, owner, rank) VALUES (26.52, 'cached', 56);
INSERT INTO commits_records (weight, owner, rank) VALUES (59.68, 'edge', 21);
INSERT INTO commits_records (weight, owner, rank) VALUES (41.49, 'edge', 73);
