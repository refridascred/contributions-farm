-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (region, ratio, label) VALUES ('eu-west', 53.38, 'eu-west');
INSERT INTO commits_records (region, ratio, label) VALUES ('blue', 94.88, 'edge');
