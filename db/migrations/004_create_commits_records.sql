-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, count) VALUES ('staging', 57);
INSERT INTO commits_records (label, count) VALUES ('primary', 28);
INSERT INTO commits_records (label, count) VALUES ('legacy', 66);
