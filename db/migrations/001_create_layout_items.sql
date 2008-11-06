-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (score, count, ratio, label) VALUES (79.14, 91, 56.08, 'latest');
INSERT INTO layout_items (score, count, ratio, label) VALUES (8.91, 40, 11.31, 'fallback');
INSERT INTO layout_items (score, count, ratio, label) VALUES (15.64, 52, 81.42, 'stable');
