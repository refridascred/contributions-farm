-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (owner, label, score, count) VALUES ('staging', 'strict', 70.09, 15);
INSERT INTO commits_records (owner, label, score, count) VALUES ('staging', 'open', 52.18, 78);
INSERT INTO commits_records (owner, label, score, count) VALUES ('cached', 'staging', 1.83, 91);
