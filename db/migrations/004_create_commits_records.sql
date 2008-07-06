-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (active, owner, score) VALUES (34, 'stable', 37.29);
INSERT INTO commits_records (active, owner, score) VALUES (68, 'fallback', 22.4);
INSERT INTO commits_records (active, owner, score) VALUES (59, 'eu-west', 71.48);
