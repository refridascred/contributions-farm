-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (score, weight, owner, label) VALUES (56.61, 1.93, 'stable', 'strict');
INSERT INTO commits_records (score, weight, owner, label) VALUES (34.53, 36.98, 'blue', 'edge');
INSERT INTO commits_records (score, weight, owner, label) VALUES (60.63, 93.42, 'staging', 'blue');
