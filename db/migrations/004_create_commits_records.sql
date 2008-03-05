-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, active) VALUES ('blue', 32);
INSERT INTO commits_records (label, active) VALUES ('staging', 98);
INSERT INTO commits_records (label, active) VALUES ('standard', 94);
