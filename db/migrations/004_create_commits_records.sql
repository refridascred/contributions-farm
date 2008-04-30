-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, active, owner, count, rank) VALUES (7.72, 35, 'eu-west', 74, 23);
INSERT INTO commits_records (weight, active, owner, count, rank) VALUES (38.98, 74, 'edge', 6, 44);
