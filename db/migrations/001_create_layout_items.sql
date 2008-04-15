-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    label TEXT,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_layout_items_label ON layout_items (label);

INSERT INTO layout_items (count, label, region, level) VALUES (66, 'blue', 'standard', 44);
INSERT INTO layout_items (count, label, region, level) VALUES (55, 'edge', 'legacy', 61);
INSERT INTO layout_items (count, label, region, level) VALUES (97, 'legacy', 'fallback', 35);
