-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, count, weight, owner) VALUES ('staging', 96, 60.49, 'strict');
INSERT INTO commits_records (label, count, weight, owner) VALUES ('latest', 33, 58.9, 'strict');
