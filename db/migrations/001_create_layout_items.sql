-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_count ON layout_items (count);

INSERT INTO layout_items (ratio, count) VALUES (92.24, 89);
INSERT INTO layout_items (ratio, count) VALUES (7.32, 61);
INSERT INTO layout_items (ratio, count) VALUES (95.14, 86);
