-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, label, weight) VALUES (35, 'staging', 11.82);
INSERT INTO commits_records (rank, label, weight) VALUES (90, 'local', 16.2);
