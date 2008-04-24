-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    score REAL NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (count, score, ratio, label, region) VALUES (44, 9.51, 50.66, 'local', 'strict');
INSERT INTO layout_items (count, score, ratio, label, region) VALUES (32, 82.72, 75.71, 'open', 'latest');
