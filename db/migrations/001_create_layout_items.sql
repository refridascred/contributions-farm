-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, weight, ratio) VALUES (98, 13.99, 14.5);
INSERT INTO layout_items (active, weight, ratio) VALUES (10, 34.88, 49.26);
