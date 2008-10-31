-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (count, owner, label, ratio) VALUES (10, 'eu-west', 'latest', 46.71);
INSERT INTO commits_records (count, owner, label, ratio) VALUES (82, 'latest', 'blue', 2.54);
