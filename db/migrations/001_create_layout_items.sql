-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    label TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (active, weight, label, ratio, count) VALUES (67, 79.17, 'edge', 68.32, 21);
INSERT INTO layout_items (active, weight, label, ratio, count) VALUES (4, 88.76, 'fallback', 68.96, 16);
