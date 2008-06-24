-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, score, owner, label, count) VALUES (58.84, 66.07, 'legacy', 'stable', 85);
INSERT INTO commits_records (weight, score, owner, label, count) VALUES (59.23, 11.86, 'green', 'open', 74);
INSERT INTO commits_records (weight, score, owner, label, count) VALUES (59.3, 20.59, 'open', 'primary', 80);
