-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (count, active, owner, label, weight) VALUES (64, 80, 'cached', 'eu-west', 7.59);
INSERT INTO commits_records (count, active, owner, label, weight) VALUES (6, 73, 'eu-west', 'primary', 12.84);
INSERT INTO commits_records (count, active, owner, label, weight) VALUES (44, 15, 'cached', 'edge', 37.75);
