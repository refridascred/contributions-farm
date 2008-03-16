-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (score, owner, weight, active) VALUES (92.98, 'eu-west', 32.66, 51);
INSERT INTO commits_records (score, owner, weight, active) VALUES (20.27, 'green', 56.48, 33);
