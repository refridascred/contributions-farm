-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, label, ratio) VALUES (60.94, 'edge', 37.84);
INSERT INTO commits_records (weight, label, ratio) VALUES (38.58, 'open', 50.75);
