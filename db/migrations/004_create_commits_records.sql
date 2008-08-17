-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (label, active, count, owner, score) VALUES ('standard', 48, 91, 'open', 57.24);
INSERT INTO commits_records (label, active, count, owner, score) VALUES ('local', 42, 1, 'legacy', 36.18);
INSERT INTO commits_records (label, active, count, owner, score) VALUES ('open', 31, 86, 'open', 44.18);
