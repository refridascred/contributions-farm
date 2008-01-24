-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (region, label, weight) VALUES ('eu-west', 'eu-west', 48.22);
INSERT INTO commits_records (region, label, weight) VALUES ('standard', 'blue', 86.1);
