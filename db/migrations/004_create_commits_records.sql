-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (owner, active, token, rank) VALUES ('primary', 97, 'local', 36);
INSERT INTO commits_records (owner, active, token, rank) VALUES ('edge', 5, 'open', 52);
INSERT INTO commits_records (owner, active, token, rank) VALUES ('local', 87, 'standard', 74);
