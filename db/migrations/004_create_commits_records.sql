-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    token TEXT,
    weight REAL,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (active, rank, token, weight, owner) VALUES (38, 2, 'blue', 60.57, 'stable');
INSERT INTO commits_records (active, rank, token, weight, owner) VALUES (98, 97, 'open', 77.71, 'strict');
INSERT INTO commits_records (active, rank, token, weight, owner) VALUES (69, 68, 'fallback', 30.19, 'standard');
