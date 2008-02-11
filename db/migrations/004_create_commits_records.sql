-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, label, score, weight) VALUES ('stable', 'blue', 94.84, 80.99);
INSERT INTO commits_records (owner, label, score, weight) VALUES ('primary', 'open', 43.86, 33.49);
