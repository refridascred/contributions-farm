-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, ratio, level) VALUES ('legacy', 42.52, 79);
INSERT INTO commits_records (label, ratio, level) VALUES ('primary', 0.36, 51);
