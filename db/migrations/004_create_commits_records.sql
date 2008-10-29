-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (count, label, weight, owner, ratio) VALUES (6, 'staging', 29.91, 'latest', 43.73);
INSERT INTO commits_records (count, label, weight, owner, ratio) VALUES (28, 'strict', 29.78, 'green', 27.32);
