-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, ratio) VALUES ('primary', 11.44);
INSERT INTO commits_records (label, ratio) VALUES ('local', 65.75);
INSERT INTO commits_records (label, ratio) VALUES ('legacy', 92.25);
