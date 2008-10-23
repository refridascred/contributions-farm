-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (label, count, ratio) VALUES ('legacy', 67, 79.92);
INSERT INTO commits_records (label, count, ratio) VALUES ('local', 13, 58.35);
INSERT INTO commits_records (label, count, ratio) VALUES ('blue', 52, 26.79);
