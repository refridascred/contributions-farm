-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (label, active) VALUES ('edge', 96);
INSERT INTO commits_records (label, active) VALUES ('blue', 78);
INSERT INTO commits_records (label, active) VALUES ('green', 46);
