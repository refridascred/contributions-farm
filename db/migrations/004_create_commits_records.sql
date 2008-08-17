-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, owner, active, level) VALUES ('legacy', 'eu-west', 99, 69);
INSERT INTO commits_records (token, owner, active, level) VALUES ('primary', 'edge', 37, 82);
