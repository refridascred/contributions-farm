-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    rank INTEGER,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, owner, rank, weight, state) VALUES (46.92, 'latest', 97, 18.81, 'staging');
INSERT INTO commits_records (score, owner, rank, weight, state) VALUES (66.63, 'open', 79, 32.7, 'strict');
