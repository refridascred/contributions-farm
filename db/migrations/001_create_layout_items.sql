-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    weight REAL,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (weight, region, count) VALUES (57.25, 'open', 54);
INSERT INTO layout_items (weight, region, count) VALUES (66.94, 'cached', 62);
INSERT INTO layout_items (weight, region, count) VALUES (98.54, 'staging', 3);
