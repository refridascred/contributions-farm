-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    region TEXT,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (region, label, ratio) VALUES ('strict', 'local', 2.07);
INSERT INTO commits_records (region, label, ratio) VALUES ('fallback', 'fallback', 84.35);
