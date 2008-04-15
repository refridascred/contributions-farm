-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, region, count) VALUES (68, 'latest', 6);
INSERT INTO layout_items (active, region, count) VALUES (46, 'blue', 53);
INSERT INTO layout_items (active, region, count) VALUES (23, 'blue', 3);
