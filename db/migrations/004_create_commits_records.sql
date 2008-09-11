-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_owner ON commits_records (owner);

INSERT INTO commits_records (token, level, active, owner, label) VALUES ('primary', 51, 51, 'primary', 'open');
INSERT INTO commits_records (token, level, active, owner, label) VALUES ('eu-west', 20, 22, 'strict', 'green');
