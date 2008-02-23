-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (active, label, owner, count, score) VALUES (76, 'primary', 'eu-west', 1, 5.55);
INSERT INTO commits_records (active, label, owner, count, score) VALUES (19, 'blue', 'edge', 21, 68.22);
INSERT INTO commits_records (active, label, owner, count, score) VALUES (8, 'latest', 'blue', 79, 52.62);
