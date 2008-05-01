-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, owner, ratio) VALUES (41, 'open', 35.46);
INSERT INTO commits_records (active, owner, ratio) VALUES (19, 'eu-west', 7.75);
INSERT INTO commits_records (active, owner, ratio) VALUES (5, 'edge', 27.17);
