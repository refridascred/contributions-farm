-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, weight, owner, count) VALUES (7, 31.39, 'local', 89);
INSERT INTO commits_records (active, weight, owner, count) VALUES (29, 48.42, 'strict', 70);
INSERT INTO commits_records (active, weight, owner, count) VALUES (7, 88.31, 'eu-west', 91);
