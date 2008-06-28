-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, active, label, count) VALUES (17.07, 47, 'edge', 43);
INSERT INTO layout_items (ratio, active, label, count) VALUES (34.07, 75, 'staging', 22);
INSERT INTO layout_items (ratio, active, label, count) VALUES (62.23, 92, 'staging', 61);
