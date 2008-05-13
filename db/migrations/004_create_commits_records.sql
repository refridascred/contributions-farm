-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (owner, active, level) VALUES ('local', 73, 19);
INSERT INTO commits_records (owner, active, level) VALUES ('legacy', 58, 33);
INSERT INTO commits_records (owner, active, level) VALUES ('open', 18, 75);
