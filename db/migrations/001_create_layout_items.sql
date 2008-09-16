-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_region ON layout_items (region);

INSERT INTO layout_items (active, region, label) VALUES (34, 'cached', 'edge');
INSERT INTO layout_items (active, region, label) VALUES (76, 'edge', 'edge');
INSERT INTO layout_items (active, region, label) VALUES (14, 'standard', 'legacy');
