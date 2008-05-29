-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    active INTEGER NOT NULL DEFAULT 1,
    rank INTEGER,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (count, active, rank, label) VALUES (79, 95, 43, 'standard');
INSERT INTO commits_records (count, active, rank, label) VALUES (22, 8, 23, 'local');
INSERT INTO commits_records (count, active, rank, label) VALUES (53, 90, 40, 'eu-west');
