-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    weight REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (region, weight, active, label) VALUES ('primary', 27.78, 64, 'green');
INSERT INTO commits_records (region, weight, active, label) VALUES ('latest', 93.2, 27, 'primary');
