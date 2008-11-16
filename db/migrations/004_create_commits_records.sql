-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    weight REAL,
    owner TEXT NOT NULL,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (rank, weight, owner, level, state) VALUES (23, 33.37, 'primary', 3, 'edge');
INSERT INTO commits_records (rank, weight, owner, level, state) VALUES (34, 96.13, 'legacy', 57, 'legacy');
