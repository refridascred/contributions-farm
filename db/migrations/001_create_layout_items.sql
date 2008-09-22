-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_active ON layout_items (active);

INSERT INTO layout_items (active, region, weight) VALUES (6, 'staging', 51.63);
INSERT INTO layout_items (active, region, weight) VALUES (62, 'edge', 21.27);
INSERT INTO layout_items (active, region, weight) VALUES (71, 'green', 27.65);
