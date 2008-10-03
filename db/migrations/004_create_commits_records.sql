-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (level, weight, label, ratio) VALUES (71, 3.97, 'open', 90.0);
INSERT INTO commits_records (level, weight, label, ratio) VALUES (40, 22.4, 'fallback', 35.69);
INSERT INTO commits_records (level, weight, label, ratio) VALUES (22, 80.4, 'strict', 76.05);
