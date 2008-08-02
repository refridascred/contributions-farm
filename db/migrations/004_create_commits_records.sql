-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (token, active, owner) VALUES ('blue', 79, 'local');
INSERT INTO commits_records (token, active, owner) VALUES ('eu-west', 32, 'staging');
INSERT INTO commits_records (token, active, owner) VALUES ('primary', 62, 'standard');
