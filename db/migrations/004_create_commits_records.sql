-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_created_at ON commits_records (created_at);

INSERT INTO commits_records (rank, active, label) VALUES (97, 12, 'standard');
INSERT INTO commits_records (rank, active, label) VALUES (43, 54, 'eu-west');
INSERT INTO commits_records (rank, active, label) VALUES (90, 92, 'open');
