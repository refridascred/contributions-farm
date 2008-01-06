-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, weight, owner) VALUES (63.56, 76.12, 'staging');
INSERT INTO commits_records (score, weight, owner) VALUES (64.52, 95.07, 'blue');
