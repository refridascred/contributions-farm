-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, label, active) VALUES (6, 'fallback', 32);
INSERT INTO commits_records (rank, label, active) VALUES (59, 'local', 25);
INSERT INTO commits_records (rank, label, active) VALUES (72, 'open', 54);
