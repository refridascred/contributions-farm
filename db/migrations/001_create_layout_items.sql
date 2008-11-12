-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (region, count, label) VALUES ('green', 27, 'stable');
INSERT INTO layout_items (region, count, label) VALUES ('green', 98, 'strict');
INSERT INTO layout_items (region, count, label) VALUES ('legacy', 69, 'blue');
