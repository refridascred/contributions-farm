-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    weight REAL,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, owner, weight, token, rank) VALUES (5, 'cached', 18.57, 'latest', 89);
INSERT INTO commits_records (active, owner, weight, token, rank) VALUES (41, 'standard', 28.52, 'legacy', 52);
