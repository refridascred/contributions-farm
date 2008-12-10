-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, rank, score, owner) VALUES (76.77, 84, 57.25, 'staging');
INSERT INTO commits_records (weight, rank, score, owner) VALUES (65.11, 59, 43.75, 'blue');
INSERT INTO commits_records (weight, rank, score, owner) VALUES (61.89, 60, 96.78, 'eu-west');
