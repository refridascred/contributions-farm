-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    weight REAL,
    rank INTEGER,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (token, weight, rank, ratio, label) VALUES ('fallback', 33.79, 26, 28.15, 'eu-west');
INSERT INTO commits_records (token, weight, rank, ratio, label) VALUES ('blue', 51.6, 83, 84.62, 'eu-west');
