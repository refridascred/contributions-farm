-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (weight, active, score, owner, ratio) VALUES (98.89, 43, 3.41, 'open', 20.27);
INSERT INTO commits_records (weight, active, score, owner, ratio) VALUES (3.94, 27, 12.54, 'eu-west', 79.71);
