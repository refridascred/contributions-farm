-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (active, level, owner) VALUES (78, 73, 'staging');
INSERT INTO commits_records (active, level, owner) VALUES (66, 62, 'green');
INSERT INTO commits_records (active, level, owner) VALUES (96, 58, 'staging');
